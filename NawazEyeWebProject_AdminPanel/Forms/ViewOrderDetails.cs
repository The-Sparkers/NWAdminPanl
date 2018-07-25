using NawazEyeWebProject.Models;
using NawazEyeWebProject_AdminPanel.ProjectClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace NawazEyeWebProject_AdminPanel.Forms
{
    public partial class ViewOrderDetails : Form
    {
        Order order;
        public ViewOrderDetails(Order order)
        {
            InitializeComponent();
            this.order = order;
            Reset();
        }
        public void Reset()
        {
            try
            {
                List<ItemViewModel> l = new List<ItemViewModel>();
                ItemViewModel ivm;
                foreach (var item in order.Cart.PrescriptionGlasses)
                {
                    ivm = new ItemViewModel(item.Prescription) { Id = item.PrescriptionGlasses.ProductId, Name = item.PrescriptionGlasses.Name, Price = item.ItemTotal, Quantity = item.Quantity };
                    l.Add(ivm);
                }
                foreach (var item in order.Cart.Sunglasses)
                {
                    ivm = new ItemViewModel() { Id = item.Sunglasses.ProductId, Name = item.Sunglasses.Name, Price = item.ItemTotal, Quantity = item.Quantity };
                    l.Add(ivm);
                }
                BindingSource itemsBinding = new BindingSource();
                itemsBinding.DataSource = l;
                itemsBinding.Sort = "Name";
                dataItemsLst.DataSource = itemsBinding;
                dataItemsLst.Columns[4].Visible = false;
                txtCity.Text = order.Cart.Buyer.City.Name;
                txtDeliveryCharges.Text = decimal.Round(order.Cart.Buyer.City.DeliverCharges).ToString();
                txtOrderId.Text = order.OrderId.ToString();
                txtPromoDiscount.Text = "% " + order.Promo.Discount.ToString();  
                txtAddress.Text = order.Cart.Buyer.Address;
                txtName.Text = order.Cart.Buyer.Name;
                txtTotalPrice.Text = decimal.Round(order.TotalPrice).ToString();
                decimal gTotal = Convert.ToInt32(txtDeliveryCharges.Text) + order.GetDiscountedPrice();
                txtGTotal.Text = gTotal.ToString();
                if (order.Status.Contains("PENDING"))
                {
                    btnStatus.Text = "IN PROGRESS";
                }
                else if (order.Status.Contains("IN PROGRESS"))
                {
                    btnStatus.Text = "DISPATCHED";
                }
                else if (order.Status.Contains("DISPATCHED"))
                {
                    btnStatus.Enabled = false;
                }
            }
            catch (InvalidCastException)
            {

            }
            catch(Exception ex)
            {
                MessageBoxes.Error(ex.Message);
            }
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (order.Status.Contains("PENDING"))
                {
                    order.Status = "IN PROGRESS";
                    Close();
                }
                else if (order.Status.Contains("IN PROGRESS"))
                {
                    DispatchedDetails dd = new DispatchedDetails(order.Cart.Buyer.Name);
                    if (dd.ShowDialog() == DialogResult.OK)
                    {
                        order.Status = "DISPATCHED";
                        order.DispatchDate = DateTime.Now;
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxes.Error(ex.Message);
            }
        }

        private void btnViewPrescription_Click(object sender, EventArgs e)
        {
            string prescription = (string)dataItemsLst.SelectedRows[0].Cells[4].Value;
            int id = (int)dataItemsLst.SelectedRows[0].Cells[0].Value;
            if (Product.IsPrescriptionGlasses(id))
            {
                string path = System.Configuration.ConfigurationManager.AppSettings["PrescriptionsPath"];
                string file = path + prescription;
                ViewPrescription vp = new ViewPrescription(file, id);
                vp.Show();
            }
            else
            {
                MessageBoxes.Info("No Prescription is attached with this item.");
            }
        }

        private void btnViewBuyer_Click(object sender, EventArgs e)
        {
            try
            {
                ViewCustomers vc = new ViewCustomers(order.Cart.Buyer);
                vc.Show();
            }
            catch(Exception ex)
            {
                MessageBoxes.Error(ex.Message);
            }
        }

        private void btnPrntDetails_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDialog pDialog = new PrintDialog();
                PrintDocument pDocument = new PrintDocument();
                pDialog.Document = pDocument;
                pDocument.PrintPage += PDocument_PrintPage;
                if (pDialog.ShowDialog() == DialogResult.OK)
                {
                    pDocument.Print();
                }
            }
            catch(Exception ex)
            {
                MessageBoxes.Error(ex.Message);
            }
        }

        private void PDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);
            float fontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;
            graphic.DrawString("Eyeworld.com\nOrder Details", new Font("Ariel Black", 18), new SolidBrush(Color.Black), startX, startY);
            offset += 20;
            graphic.DrawString("Receiver Name: " + order.Cart.Buyer.Name, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += 20;
            graphic.DrawString("Postal Address: " + order.Cart.Buyer.Address, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += 20;
            graphic.DrawString("Phone Number: " + order.Cart.Buyer.PhoneNumber, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 20;
            graphic.DrawString("Items:",new Font("Ariel Black",14,FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 20;
            foreach (var item in order.Cart.PrescriptionGlasses)
            {
                graphic.DrawString(item.PrescriptionGlasses.Name + "\t" + item.Quantity, font, new SolidBrush(Color.Black), startX, startY + offset);
                offset += 20;
            }
            foreach (var item in order.Cart.Sunglasses)
            {
                graphic.DrawString(item.Sunglasses.Name + "\t" + item.Quantity, font, new SolidBrush(Color.Black), startX, startY + offset);
                offset += 20;
            }
            graphic.DrawString("Thanks for shopping",new Font("Ariel Black",16), new SolidBrush(Color.Black), startX, startY + offset);
        }
    }
    public class ItemViewModel
    {
        string prescription;
        public ItemViewModel()
        {

        }
        public ItemViewModel(string prescription)
        {
            this.prescription = prescription;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Prescrption
        {
            get
            {
                return prescription;
            }
        }
    }
}
