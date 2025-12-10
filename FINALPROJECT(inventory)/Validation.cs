using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALPROJECT_inventory_
{
    internal class Validation
    {
        string name; //can be product or location name
        string description;
        string category;
        double price;
        string address;
        string type;
        int quantity;

        int constructorUsed;

        //Product Constructor
        public Validation(string Name, string Desc, string Category, double Price)
        {
            name = Name.Trim();
            description = Desc.Trim();
            category = Category.Trim();
            price = Price;

            constructorUsed = 1;
        }

        //Location Constructor
        public Validation(string Name, string Address, string Type)
        {
            name = Name.Trim();
            address = Address.Trim();
            type = Type.Trim();

            constructorUsed = 2;
        }

        //Stock Constructor
        public Validation(int Quantity)
        {
            quantity = Quantity;
            constructorUsed = 3;
        }

        public string checkValues()
        {
            if (constructorUsed == 1)
            {
                if(string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(category) || price == 0.0)
                {
                    return "Fill in all fields";
                }

                else if (price <= 0.0)
                {
                    return "Price must be greater then $0.00";
                }
            }
            else if (constructorUsed == 2)
            {
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(type))
                {
                    return "Fill in all fields";
                }
                else if (type != "Store" || type != "Warehouse")
                {
                    return "Type must be either \"Store\" or \"Warehouse\"";
               }
            }
            else // constructor 3
            {
                if (quantity < 0)
                {
                    return "Quantity cannot be negative";
                }
            }

            return "";
        }
    }
}
