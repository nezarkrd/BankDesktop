using BANKDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_BuisnessLayer
{
    public class clsCurrency
    {
        public enum enMode { AddMode = 0, UpdateMode = 1 }
        enMode Mode = enMode.AddMode;
        public int CurrencyID { get; set; }
        public string Country { get; set; }
        public string Code { get; set; }
      
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public clsCountry infoCountry { get; set; }



        public clsCurrency()
        {
            this.CurrencyID = -1;
            this.Country = "";
            this.Code = "";
            this.Name = "";
            this.Rate = 0;
          

            Mode = enMode.AddMode;
        }


        private clsCurrency(int CurrencyID, string Country, string Code, string Name,decimal Rate)
        {
            this.CurrencyID = CurrencyID;
            this.Country = Country;
            this.Code = Code;
            this.Name = Name;
            this.Rate = Rate;
            Mode = enMode.UpdateMode;
        }

        public static clsCurrency Find(int CurrencyID)
        {
            string Country = "", Code = "", Name = ""; decimal Rate = 0;


            bool isFound = clsCurrenciesData.GetCurrencyByIDCurrency(CurrencyID, ref Country, ref Code, ref Name, ref Rate);

            if (isFound == true)
            {

                return new clsCurrency( CurrencyID,  Country,  Code,  Name, Rate);
            }
            else
            {
                return null;
            }



        }

        public static clsCurrency FindByCountry(string Country)
        {
            int CurrencyID = -1;string Code = "", Name = ""; decimal Rate = 0;

           
            bool isFound = clsCurrenciesData.GetCurrencyByCountry(Country, ref CurrencyID, ref Code, ref Name, ref Rate);

            if (isFound == true)
            {

                return new clsCurrency(CurrencyID, Country, Code, Name, Rate);
            }
            else
            {
                return null;
            }



        }

        public static clsCurrency FindByCode(string Code)
        {
            int CurrencyID = -1; string Country = "", Name = ""; decimal Rate = 0;

          
            bool isFound = clsCurrenciesData.GetCurrencyByCode(Code, ref CurrencyID, ref Country, ref Name, ref Rate);

            if (isFound == true)
            {

                return new clsCurrency(CurrencyID, Country, Code, Name, Rate);
            }
            else
            {
                return null;
            }



        }


       

        public static bool isCurrencyExist(int CurrencyID)
        {
            
            return clsCurrenciesData.IsCurrencyExist(CurrencyID);
        }


        public static bool isCurrencyExistByCountry(string Country)
        {
            
            return clsCurrenciesData.IsCurrencyExistByCountry(Country);

        }

        public static bool isCurrencyExistByCode(string Code)
        {
            
            return clsCurrenciesData.IsCurrencyExistByCode(Code);


        }



        private bool _AddNewCurrency()
        {
            this.CurrencyID = clsCurrenciesData.AddNewCurrency(this.Country,this.Code, this.Name, this. Rate);
            return (this.CurrencyID != -1);
    

        }
        private bool _UpdateCurrency()
        {
            return clsCurrenciesData.UpdateCurrency(this.CurrencyID,this.Country,this.Code,this.Name,this.Rate);
         

        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddMode:
                    if (_AddNewCurrency())
                    {
                        Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                    {

                        return false;
                    }

                case enMode.UpdateMode:
                    return _UpdateCurrency();

            }
            return false;
        }


        public static bool DeleteCurrency(int CurrencyID)
        {
            
            return clsCurrenciesData.DeleteCurrency(CurrencyID);
        }

        public static DataTable GetAllCurrencies()
        {
            return clsCurrenciesData.GetAllCurrencies();    

        }

        private static decimal _ConvertToUSD(decimal Amount,decimal Rate)
        {
            return (decimal)(Amount / Rate);
        }
        public static  decimal ConvertToOtherCurrency(decimal Amount, clsCurrency Currency1, clsCurrency Currency2)
        {
            decimal AmountInUSD = _ConvertToUSD(Amount, Currency1.Rate);

            if (Currency2.Code == "USD")
            {
                return AmountInUSD;
            }

            return (decimal)(AmountInUSD * Currency2.Rate);

        }

        //public static decimal ConvertCurrency(string CodeCurrency1, string CodeCurrency2,decimal Amount)
        //{

        //    clsCurrency Currency1 = FindByCode(CodeCurrency1);
        //    clsCurrency Currency2 = FindByCode(CodeCurrency2);

        //    if (CodeCurrency1 == "USD")
        //    {
        //        Currency1
        //    }
        //    else
        //    {

        //    }

        //}




    }
}
