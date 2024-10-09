﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi*****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potato, tomato;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potato = 9.74;
            //tomato = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potato + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomato + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potato * potatoGram;
            //double tomatoTotalPrice = tomato * tomatoGram;

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyatı: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyatı: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyatı: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyatı: " + potato + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyatı: " + tomato + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice + " TL");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Toplam Alışveriş Tutarı: " + shoppingTotalPrice + " TL");


            #endregion


            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);


            #endregion


            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu Kimlik Numarası: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("---------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " +  passengerIdentityNumber + " - " + "Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " - " + passengerDistrict + "/" + passengerCity + " " + passengerAge);

            #endregion


            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;    


            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount =int.Parse( Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesPrice * shoesCount + computerPrice * computerCount + chairPrice * chairCount + tvPrice * tvCount;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);  




            #endregion


            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen Birinci Sınav Sonucunu Giriniz: ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen İkinci Sınav Sonucunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen Üçüncü Sınav Sonucunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Ortalamanız: " + result);



            #endregion


            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender=char.Parse(Console.ReadLine());
            

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion



            Console.Read();
        }
    }
}
