using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EXERCISE_02___CONSTRUCTOR {
    //------------------------------- START -------------------------------//
    class Product {
        public string Name;
        public double Price;
        public int Amount;

        //------------------------- MET. CLASS ----------------------------//
        public Product( string name, double price, int amount) {
            Name = name;
            Price = price;
            Amount = amount;
        }
        public double TotalValueStock() {
            return Price * Amount;
        }
        public void AddProduct(int amount) {
            Amount += amount;
        }
        public void RemoveProduct(int amount) {
            Amount -= amount;
        }
        public override string ToString() {
            return Name
                + "| $ " + Price.ToString("F2") + "| " + Amount + "  Unidades | Total: $ " + TotalValueStock().ToString("F2");
        }
    }
    //-------------------------------- END -------------------------------// 
}
