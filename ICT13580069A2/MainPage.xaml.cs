using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICT13580069A2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            newButton.Clicked += NewButton_Clicked;
        }
        protected override void OnAppearing()
        {
            LoadData();
        }
        void LoadData()
        {
            productListView.ItemsSource = App.Dbhelper.GetProducts();
        }
        void NewButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ProductPage());

        }

        void Edit_Clicked(object sender, System.EventArgs e)
        {
            var button = sender as MenuItem;
            var product = button.CommandParameter as product;
            Navigation.PushModalAsync(new ProductPage(product));
        }

        void Delete_Clicked(object sender, System.EventArgs e)
        {
            var isOK = await DisplayAlert("ยืนยัน", "คุณต้องการลบใช่หรือไม่", "ใช่", "ไม่ใช่");
            if (isOK)
            {
                var button = sender as MenuItem;
                var product = button.CommandParameter as product;
                App.Dbhelper.DeleteProduct(product);

                await DisplayAlert("ลบสำเร็จ","ลบข้อมูลสินค้าเรียบร้อย","ตกลง");
                LoadData();

            }
        }
    }
}
