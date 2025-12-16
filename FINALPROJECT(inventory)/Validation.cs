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
        string name =""; //can be product or location name
        string description= "";
        string category = "";
        decimal price = 0.0m;
        string address = "";
        string type = "";
        int quantity = 0;

        int constructorUsed;

        //Product Constructor
        public Validation(string Name, string Desc, string Category, decimal Price)
        {
            name = Name.Trim();
            description = Desc.Trim();
            category = Category.Trim();
            price = (decimal)Price;

            constructorUsed = 1;
        }

        //Location Constructor
        public Validation(string Name, string Address, string Type)
        {
            name = Name.Trim();
            address = Address.Trim();
            type = Type.Trim().ToLower();

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
                if(string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(category))
                {
                    return "Fill in all fields";
                }

                else if (price <= 0.0m)
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
                else if (type != "store" && type != "warehouse")
                {
                    return "Type must be either \"store\" or \"warehouse\"";
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
