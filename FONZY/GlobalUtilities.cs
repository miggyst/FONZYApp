using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FONZY
{
    public class GlobalUtilities
    {
        //----- Variables to take note of -----//
        //Generic Constant String Variables
        public const string MASTER = "master";
        public const string CUSTOMER = "customer";

        // Cashier information
        private static string cashierName;
        private static string eventName;

        // Customer Information
        private static string customerName;
        private static string customerAddress;
        private static string customerContact;
        private static string customerTIN;
        private static string customerBusinessStyle;
        private static string customerTerms;
        private static string customerOSCA;
        private static string customerType;

        // Customer order data
        private static Dictionary<string, List<string>> masterListDictionary = new Dictionary<string, List<string>>();
        private static Dictionary<string, List<string>> customerTransactionDictionary = new Dictionary<string, List<string>>();
        private static bool cashPaymentIdentifier;
        private static bool creditPaymentIdentifier;
        private static bool debitPaymentIdentifier;
        private static bool checkPaymentIdentifier;
        private static bool salaryDeductionPaymentIdentifier;
        private static double cashPayment = 0;
        private static double creditPayment = 0;
        private static double debitPayment = 0;
        private static double checkPayment = 0;
        private static double salaryDeductionPayment = 0;
        private static double totalCost = 0;
        private static double totalChange = 0;
        private static string totalQuantity = "0";

        // Folder FilePath for saved data
        private static string masterFilePath;
        private static string cashierAndEventFilePath;

        //----- Public functions -----//
        //--- GETters ---//
        public static string getCashierName() { return cashierName; }

        public static string getEventName() { return eventName; }

        public static string getCustomerName() { return customerName; }

        public static string getCustomerAddress() { return customerAddress; }

        public static string getCustomerContact() { return customerContact; }

        public static string getMasterFilePath() { return masterFilePath; }

        public static string getCashierAndEventFilePath() { return cashierAndEventFilePath; }

        public static string getCustomerTIN() { return customerTIN; }

        public static string getCustomerBusinessStyle() { return customerBusinessStyle; }

        public static string getCustomerTerms() { return customerTerms; }

        public static string getCustomerOSCA() { return customerOSCA; }

        public static string getCustomerType() { return customerType; }

        public static Dictionary<string, List<string>> getMasterListDictionary() { return masterListDictionary; }

        public static Dictionary<string, List<string>> getCustomerTransactionDictionary() { return customerTransactionDictionary; }

        public static bool getCashPaymentIdentifier() { return cashPaymentIdentifier; }

        public static bool getCreditPaymentIdentifier() { return creditPaymentIdentifier; }

        public static bool getDebitPaymentIdentifier() { return debitPaymentIdentifier; }

        public static bool getCheckPaymentIdentifier() { return checkPaymentIdentifier; }

        public static bool getSalaryDeductionPaymentIdentifier() { return salaryDeductionPaymentIdentifier; }

        public static double getCashPayment() { return cashPayment; }

        public static double getCreditPayment() { return creditPayment; }

        public static double getDebitPayment() { return debitPayment; }

        public static double getCheckPayment() { return checkPayment; }

        public static double getSalaryDeductionPayment() { return salaryDeductionPayment; }

        public static double getTotalCost() { return totalCost; }

        public static double getTotalChange() { return totalChange; }

        public static string getTotalQuantity() { return totalQuantity; }

        //----- SETters -----//
        public static void setCashierName(string userInputCashierName)
        {
            cashierName = userInputCashierName;
        }

        public static void setEventName(string userInputEventName)
        {
            eventName = userInputEventName;
        }

        public static void setCustomerName(string userInputCustomerName)
        {
            customerName = userInputCustomerName;
        }

        public static void setCustomerAddress(string userInputCustomerAddress)
        {
            customerAddress = userInputCustomerAddress;
        }

        public static void setCustomerContact(string userInputCustomerContact)
        {
            customerContact = userInputCustomerContact;
        }

        public static void setMasterFilePath(string userInputMasterFilePath)
        {
            masterFilePath = userInputMasterFilePath;
        }

        public static void setCashierAndEventFilePath(string userInputCashierAndEventFilePath)
        {
            cashierAndEventFilePath = userInputCashierAndEventFilePath;
        }
        
        public static void setCustomerTIN(string userInputCustomerTIN)
        {
            customerTIN = userInputCustomerTIN;
        }

        public static void setCustomerBusinessStyle(string userInputCustomerBusinessStyle)
        {
            customerBusinessStyle = userInputCustomerBusinessStyle;
        }

        public static void setCustomerTerms(string userInputCustomerTerms)
        {
            customerTerms = userInputCustomerTerms;
        }

        public static void setCustomerOSCA(string userInputCustomerOSCA)
        {
            customerOSCA = userInputCustomerOSCA;
        }

        public static void setCustomerType(string userInputCustomerType)
        {
            customerType = userInputCustomerType;
        }

        public static void setCashPaymentIdentifier(bool userInputCashPaymentIdentifier)
        {
            cashPaymentIdentifier = userInputCashPaymentIdentifier;
        }

        public static void setCreditPaymentIdentifier(bool userInputCreditPaymentIdentifier)
        {
            creditPaymentIdentifier = userInputCreditPaymentIdentifier;
        }

        public static void setDebitPaymentIdentifier(bool userInputDebitPaymentIdentifier)
        {
            debitPaymentIdentifier = userInputDebitPaymentIdentifier;
        }

        public static void setCheckPaymentIdentifier(bool userInputCheckPaymentIdentifier)
        {
            checkPaymentIdentifier = userInputCheckPaymentIdentifier;
        }

        public static void setSalaryDeductionPaymentIdentifier(bool userInputSalaryDeductionPaymentIdentifier)
        {
            salaryDeductionPaymentIdentifier = userInputSalaryDeductionPaymentIdentifier;
        }

        public static void setCashPayment(double userInputCashPayment)
        {
            cashPayment = userInputCashPayment;
        }

        public static void setCreditPayment(double userInputCreditPayment)
        {
            creditPayment = userInputCreditPayment;
        }

        public static void setDebitPayment(double userInputDebitPayment)
        {
            debitPayment = userInputDebitPayment;
        }

        public static void setCheckPayment(double userInputCheckPayment)
        {
            checkPayment = userInputCheckPayment;
        }

        public static void setSalaryDeductionPayment(double userInputSalaryDeductionPayment)
        {
            salaryDeductionPayment = userInputSalaryDeductionPayment;
        }

        public static void setTotalCost(double userInputTotalCost)
        {
            totalCost = userInputTotalCost;
        }

        public static void setTotalQuantity(string userInputTotalQuantity)
        {
            totalQuantity = userInputTotalQuantity;
        }

        public static void setTotalChange()
        {
            totalChange = totalCost - (cashPayment + creditPayment + debitPayment + checkPayment + salaryDeductionPayment);
        }

        //----- Other Methods -----//
        /// <summary>
        /// adds an order to the dictionary if the order isn't within the dictionary beforehand,
        /// if there is already a value in the dictionary, it updates the dictionary accordingly
        /// </summary>
        /// <param name="dictionaryType"></param>
        /// <param name="userInputBarCode"></param>
        /// <param name="userInputList"></param>
        public static void addToDictionary(string dictionaryType, string userInputBarCode, List<string> userInputList)
        {
            // If there are no known Keys (userInputBarCode) in the dictionary, add a Key,Value pair
            // else update the Key,Value pair
            if (dictionaryType == MASTER)
            {
                if (masterListDictionary == null || !masterListDictionary.ContainsKey(userInputBarCode))
                {
                    masterListDictionary.Add(userInputBarCode, userInputList);
                }
                else
                {
                    masterListDictionary[userInputBarCode] = userInputList;
                }
            }
            else if(dictionaryType == CUSTOMER)
            {
                if (!customerTransactionDictionary.ContainsKey(userInputBarCode))
                {
                    customerTransactionDictionary.Add(userInputBarCode, userInputList);
                }
                else
                {
                    customerTransactionDictionary[userInputBarCode] = userInputList;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userInputBarCode"></param>
        /// <returns></returns>
        public static List<string> getProductInfoFromDictionary(string dictionaryType, string userInputBarCode)
        {
            /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
             *                                   List index legend:                                      *
             *      0    |          1           |     2     |       3       |       4       |      5     *
             * ------------------------------------------------------------------------------------------*
             *  Bar Code |  Product Description |   Price   |   Quantity    |   Discount    |   Amount   *
             * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

            List<string> productInformationList = new List<string>();
            if (dictionaryType == MASTER)
            {
                if (masterListDictionary.ContainsKey(userInputBarCode))
                {
                    productInformationList.Add(userInputBarCode);   // Bar Code
                    productInformationList.Add(masterListDictionary[userInputBarCode][1]);  // Product Description
                    productInformationList.Add(masterListDictionary[userInputBarCode][2]);  // Price
                    productInformationList.Add(masterListDictionary[userInputBarCode][4]);  // Quantity
                    productInformationList.Add(masterListDictionary[userInputBarCode][3]);  // Discount
                    productInformationList.Add(calculatePrice(masterListDictionary[userInputBarCode][2], masterListDictionary[userInputBarCode][4], masterListDictionary[userInputBarCode][3]));    // Amount
                }
            }
            else if(dictionaryType == CUSTOMER)
            {
                // Needs updating
                if (customerTransactionDictionary.ContainsKey(userInputBarCode))
                {
                    productInformationList.Add(userInputBarCode);
                }
            }
            return productInformationList;
        }

        /// <summary>
        /// resets the payment identifiers to default
        /// </summary>
        public static void resetPaymentIdentifiers()
        {
            setCashPaymentIdentifier(false);
            setCreditPaymentIdentifier(false);
            setDebitPaymentIdentifier(false);
            setCheckPaymentIdentifier(false);
            setSalaryDeductionPaymentIdentifier(false);
        }

        /// <summary>
        /// Calculates the total price of a product order given the objects passed into the method
        /// </summary>
        /// <param name="userInputPrice">price of the product</param>
        /// <param name="userInputQuantity">number of the given product</param>
        /// <param name="userInputDiscount">product discount</param>
        /// <returns></returns>
        public static string calculatePrice(string userInputPrice, string userInputQuantity, string userInputDiscount)
        {
            if(!String.IsNullOrEmpty(userInputPrice) && !String.IsNullOrEmpty(userInputQuantity) && !String.IsNullOrEmpty(userInputDiscount))
            {
                return (((Double.Parse(userInputPrice)) * (Double.Parse(userInputQuantity))) * (Double.Parse(userInputDiscount))).ToString();
            }
            return null;
        }

        /// <summary>
        /// Checks the customerTransactionDictionary if an order of the same barcode has been placed before
        /// </summary>
        /// <param name="userInputBarCode"></param>
        /// <returns></returns>
        public static bool isInCustomerTransactionDictionary(string userInputBarCode)
        {
            return customerTransactionDictionary.ContainsKey(userInputBarCode);
        }
    }
}
