﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator;


public partial class MainWindow : Window
{
    public int x = 0;
    public int y = 0;
    string cem;
    bool clear;
    char op;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void beraber_Click(object sender, RoutedEventArgs e)
    {

        y = Convert.ToInt32(label1.Content);

        switch (op)
        {

            case '+':
                cem = (x + y).ToString();

                break;
            case '*':

                cem = (x * y).ToString();



                break;

            case '-':
                cem = (x - y).ToString();



                break;
            case '/':

                cem = (x / y).ToString();

                break;

            default:
                break;
        }





        label1.Content = cem;
    }

    private void Topla_Click(object sender, RoutedEventArgs e)
    {
        op = '+';
        clear = true;
        x = Convert.ToInt32(label1.Content);
        label1.Content = "0";

    }

    private void Cix_Click(object sender, RoutedEventArgs e)
    {
        op = '-';

        clear = true;
        x = Convert.ToInt32(label1.Content);
        label1.Content = "0";
    }

    private void Vur_Click(object sender, RoutedEventArgs e)
    {
        op = '*';

        clear = true;
        x = Convert.ToInt32(label1.Content);
        label1.Content = "0";
    }

    private void bol_Click(object sender, RoutedEventArgs e)
    {
        op = '/';

        clear = true;
        x = Convert.ToInt32(label1.Content);
        label1.Content = "0";
    }



   

    private void doqquz_Click_1(object sender, RoutedEventArgs e)
    {
        if (clear)
        {
            label1.Content = "";
            clear = false;
        }
        if (label1.Content == "0")
        {
            label1.Content = "";
        }
        label1.Content += "9";
    }

    private void yeddi_Click_1(object sender, RoutedEventArgs e)
    {
        if (clear)
        {
            label1.Content = "";
            clear = false;
        }
        if (label1.Content == "0")
        {
            label1.Content = "";
        }
        label1.Content += "7";
    }

    private void sifir_Click_1(object sender, RoutedEventArgs e)
    {
        if (clear) label1.Content = "";

        label1.Content += "0";
    }

    private void sekkiz_Click_1(object sender, RoutedEventArgs e)
    {
        if (clear)
        {
            label1.Content = "";
            clear = false;
        }
        if (label1.Content == "0")
        {
            label1.Content = "";
        }
        label1.Content += "8";
    }

    private void dord_Click_1(object sender, RoutedEventArgs e)
    {
        if (clear)
        {
            label1.Content = "";
            clear = false;
        }
        if (label1.Content == "0")
        {
            label1.Content = "";
        }
        label1.Content += "4";
    }

    private void bes_Click_1(object sender, RoutedEventArgs e)
    {
        if (clear)
        {
            label1.Content = "";
            clear = false;
        }
        if (label1.Content == "0")
        {
            label1.Content = "";
        }
        label1.Content += "5";
    }

    private void alti_Click_1(object sender, RoutedEventArgs e)
    {
        if (clear)
        {
            label1.Content = "";
            clear = false;
        }
        if (label1.Content == "0")
        {
            label1.Content = "";
        }
        label1.Content += "6";
    }

    private void uc_Click_1(object sender, RoutedEventArgs e)
    {

        if (clear)
        {
            label1.Content = "";
            clear = false;
        }
        if (label1.Content == "0")
        {
            label1.Content = "";
        }
        label1.Content += "3";
    }

    private void iki_Click_1(object sender, RoutedEventArgs e)
    {
        if (clear)
        {
            label1.Content = "";
            clear = false;
        }
        if (label1.Content == "0")
        {
            label1.Content = "";
        }
        label1.Content += "2";
    }

    private void bir_Click(object sender, RoutedEventArgs e)
    {
        if (clear)
        {
            label1.Content = "";
            clear = false;
        }
        if (label1.Content == "0") label1.Content = "";

        label1.Content += "1";
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        label1.Content = "0";
    }

    private void Button_Click_1(object sender, RoutedEventArgs e)
    {
        label1.Content = "0";

    }

    private void Button_Click_2(object sender, RoutedEventArgs e)
    {
        if (label1.Content is int a)
        {
            var b = -a;
            label1.Content = b;
        }
        else if (int.TryParse(label1.Content.ToString(), out int intValue))
        {
            var b = -intValue;
            label1.Content = b;
        }
    }

    private void Button_Click_3(object sender, RoutedEventArgs e)
    {
        var a = int.TryParse((string)label1.Content, out int intv);
        label1.Content = (Math.Sqrt(intv).ToString()); 
    }

    private void Button_Click_4(object sender, RoutedEventArgs e)
    {
        var a = int.TryParse((string)label1.Content, out int intv);
        label1.Content = ((intv*intv).ToString());
    }

    private void Button_Click_5(object sender, RoutedEventArgs e)
    {
        var a = float.TryParse((string)label1.Content, out float intv);
        label1.Content = ((1 / intv).ToString());
    }

    private void Button_Click_6(object sender, RoutedEventArgs e)
    {
       
    }
}