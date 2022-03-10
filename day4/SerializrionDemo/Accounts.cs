using System;
using System.Xml.Serialization; // use this namespace to serialize and deserialize in XML Format
using System.IO;  //use this namespace to work with files, open, save, override 
namespace SerializrionDemo
{
    [Serializable] //this is an attribute, neeed for an object to come out of memory 
    public class Accounts
    {
        public int accNo { get; set; }
        public string accName { get; set; }
        public double accBalance { get; set; }
        public bool accIsActive { get; set; }
        public string accType { get; set; }
        public string accEmail { get; set; }

        public double Widraw(int amount)
        {
            
            accBalance  = accBalance - amount;
            return accBalance;
        }


         public double Deposit(int amount)
        {
            accBalance  = accBalance + amount;
            return accBalance;
        }

        public void SaveObject()
        {
                FileStream myfile = new FileStream(accNo + ".xml",FileMode.Create,FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Accounts));
                xs.Serialize(myfile,this);
                myfile.Close();
                System.Console.WriteLine("Object Saved To Disk");
        }

        public Accounts GetObject(int accountNumber)
        {
                FileStream myfile = new FileStream(accountNumber + ".xml",FileMode.Open,FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Accounts));
                Accounts details  =(Accounts) xs.Deserialize(myfile);
                myfile.Close();
                return details;

        }






    }
}