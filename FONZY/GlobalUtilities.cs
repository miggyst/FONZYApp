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
        private static Dictionary<string, List<string>> customerTransactionDictionary = new Dictionary<string, List<string>>();
        private static bool cashPaymentIdentifier;
        private static bool creditPaymentIdentifier;
        private static bool debitPaymentIdentifier;
        private static bool checkPaymentIdentifier;
        private static bool salaryDeductionPaymentIdentifier;
        private static float cashPayment;
        private static float creditPayment;
        private static float debitPayment;
        private static float checkPayment;
        private static float salaryDeductionPayment;
        private static float totalCost;
        private static float totalChange;

        // Folder FilePath for saved data
        private static string filePath;

        //----- Public functions -----//
        GlobalUtilities()
        {
            // MIGHT NEED TO DELETE THIS CONSTRUCTOR!!
            // Payment Constructor
            cashPayment = 0f;
            creditPayment = 0f;
            debitPayment = 0f;
            checkPayment = 0f;
            salaryDeductionPayment = 0f;
            totalCost = 0f;
            totalChange = 0f;
        }

        //--- GETters ---//
        public static string getCashierName() { return cashierName; }

        public static string getEventName() { return eventName; }

        public static string getCustomerName() { return customerName; }

        public static string getCustomerAddress() { return customerAddress; }

        public static string getCustomerContact() { return customerContact; }

        public static string getFilePath() { return filePath; }

        public static string getCustomerTIN() { return customerTIN; }

        public static string getCustomerBusinessStyle() { return customerBusinessStyle; }

        public static string getCustomerTerms() { return customerTerms; }

        public static string getCustomerOSCA() { return customerOSCA; }

        public static string getCustomerType() { return customerType; }

        public static bool getCashPaymentIdentifier() { return cashPaymentIdentifier; }

        public static bool getCreditPaymentIdentifier() { return creditPaymentIdentifier; }

        public static bool getDebitPaymentIdentifier() { return debitPaymentIdentifier; }

        public static bool getCheckPaymentIdentifier() { return checkPaymentIdentifier; }

        public static bool getSalaryDeductionPaymentIdentifier() { return salaryDeductionPaymentIdentifier; }

        public static float getCashPayment() { return cashPayment; }

        public static float getCreditPayment() { return creditPayment; }

        public static float getDebitPayment() { return debitPayment; }

        public static float getCheckPayment() { return checkPayment; }

        public static float getSalaryDeductionPayment() { return salaryDeductionPayment; }

        public static float getTotalCost() { return totalCost; }

        public static float getTotalChange() { return totalChange; }


        /// <summary>
        /// SETter for cashier name
        /// </summary>
        /// <param name="userInputCashierName">cashier name</param>
        public static void setCashierName(string userInputCashierName)
        {
            cashierName = userInputCashierName;
        }

        /// <summary>
        /// SETter for event name
        /// </summary>
        /// <param name="userInputEventName">event name</param>
        public static void setEventName(string userInputEventName)
        {
            eventName = userInputEventName;
        }

        /// <summary>
        /// SETter for customer name
        /// </summary>
        /// <param name="userInputCustomerName">customer name</param>
        public static void setCustomerName(string userInputCustomerName)
        {
            customerName = userInputCustomerName;
        }

        /// <summary>
        /// SETter for customer address
        /// </summary>
        /// <param name="userInputCustomerAddress">customer address</param>
        public static void setCustomerAddress(string userInputCustomerAddress)
        {
            customerAddress = userInputCustomerAddress;
        }

        /// <summary>
        /// SETter for customer contact number
        /// </summary>
        /// <param name="userInputCustomerContact">contact number</param>
        public static void setCustomerContact(string userInputCustomerContact)
        {
            customerContact = userInputCustomerContact;
        }

        /// <summary>
        /// SETter for masterfile file path
        /// </summary>
        /// <param name="userInputFilePath">file path to masterfile</param>
        public static void setFilePath(string userInputFilePath)
        {
            filePath = userInputFilePath;
        }

        /// <summary>
        /// SETter for customer TIN
        /// </summary>
        /// <param name="userInputCustomerTIN">customer TIN</param>
        public static void setCustomerTIN(string userInputCustomerTIN)
        {
            customerTIN = userInputCustomerTIN;
        }

        /// <summary>
        /// SETter for customer business style
        /// </summary>
        /// <param name="userInputCustomerBusinessStyle">customer business style</param>
        public static void setCustomerBusinessStyle(string userInputCustomerBusinessStyle)
        {
            customerBusinessStyle = userInputCustomerBusinessStyle;
        }

        /// <summary>
        /// SETter for customer terms
        /// </summary>
        /// <param name="userInputCustomerTerms">customer terms</param>
        public static void setCustomerTerms(string userInputCustomerTerms)
        {
            customerTerms = userInputCustomerTerms;
        }

        /// <summary>
        /// SETter for customer OSCA/PWD ID Number
        /// </summary>
        /// <param name="userInputCustomerOSCA">customer OSCA/PWD ID Number</param>
        public static void setCustomerOSCA(string userInputCustomerOSCA)
        {
            customerOSCA = userInputCustomerOSCA;
        }

        /// <summary>
        /// SETter for customer type
        /// </summary>
        /// <param name="userInputCustomerType">customer type</param>
        public static void setCustomerType(string userInputCustomerType)
        {
            customerType = userInputCustomerType;
        }

        /// <summary>
        /// SETter for cash payment identifier
        /// </summary>
        /// <param name="userInputCashPaymentIdentifier">cash payment identifier</param>
        public static void setCashPaymentIdentifier(bool userInputCashPaymentIdentifier)
        {
            cashPaymentIdentifier = userInputCashPaymentIdentifier;
        }

        /// <summary>
        /// SETter for credit payment identifier
        /// </summary>
        /// <param name="userInputCreditPaymentIdentifier">credit payment identifier</param>
        public static void setCreditPaymentIdentifier(bool userInputCreditPaymentIdentifier)
        {
            creditPaymentIdentifier = userInputCreditPaymentIdentifier;
        }

        /// <summary>
        /// SETter for debit payment identifier
        /// </summary>
        /// <param name="userInputDebitPaymentIdentifier">debit payment identifier</param>
        public static void setDebitPaymentIdentifier(bool userInputDebitPaymentIdentifier)
        {
            debitPaymentIdentifier = userInputDebitPaymentIdentifier;
        }

        /// <summary>
        /// SETter for check payment identifier
        /// </summary>
        /// <param name="userInputCheckPaymentIdentifier">check payment identifier</param>
        public static void setCheckPaymentIdentifier(bool userInputCheckPaymentIdentifier)
        {
            checkPaymentIdentifier = userInputCheckPaymentIdentifier;
        }

        /// <summary>
        /// SETter for salary deduction payment identifier
        /// </summary>
        /// <param name="userInputSalaryDeductionPaymentIdentifier">salary deduction payment identifier</param>
        public static void setSalaryDeductionPaymentIdentifier(bool userInputSalaryDeductionPaymentIdentifier)
        {
            salaryDeductionPaymentIdentifier = userInputSalaryDeductionPaymentIdentifier;
        }

        /// <summary>
        /// SETter for cash payment
        /// </summary>
        /// <param name="userInputCashPayment">cash payment</param>
        public static void setCashPayment(float userInputCashPayment)
        {
            cashPayment = userInputCashPayment;
        }

        /// <summary>
        /// SETter for credit payment
        /// </summary>
        /// <param name="userInputCreditPayment">credit payment</param>
        public static void setCreditPayment(float userInputCreditPayment)
        {
            creditPayment = userInputCreditPayment;
        }

        /// <summary>
        /// SETter for debit payment
        /// </summary>
        /// <param name="userInputDebitPayment">debit payment</param>
        public static void setDebitPayment(float userInputDebitPayment)
        {
            debitPayment = userInputDebitPayment;
        }

        /// <summary>
        /// SETter for check payment
        /// </summary>
        /// <param name="userInputCheckPayment">check payment</param>
        public static void setCheckPayment(float userInputCheckPayment)
        {
            checkPayment = userInputCheckPayment;
        }

        /// <summary>
        /// SETter for salary deduction payment
        /// </summary>
        /// <param name="userInputSalaryDeductionPayment">salary deduction payment</param>
        public static void setSalaryDeductionPayment(float userInputSalaryDeductionPayment)
        {
            salaryDeductionPayment = userInputSalaryDeductionPayment;
        }

        /// <summary>
        /// SETter for total cost
        /// </summary>
        /// <param name="userInputTotalCost">total cost</param>
        public static void setTotalCost(float userInputTotalCost)
        {
            totalCost = userInputTotalCost;
        }

        /// <summary>
        /// SETter for total change
        /// </summary>
        public static void setTotalChange()
        {
            totalChange = totalCost - (cashPayment + creditPayment + debitPayment + checkPayment + salaryDeductionPayment);
        }

        /// <summary>
        /// adds an order to the dictionary if the order isn't within the dictionary beforehand
        /// </summary>
        /// <param name="userInputOrderBarCode">product bar code</param>
        /// <param name="userInputOrderProductDescription">product description</param>
        /// <param name="userInputOrderPrice">product price</param>
        /// <param name="userInputOrderQuantity">product quantity</param>
        /// <param name="userInputOrderDiscount">product discount</param>
        /// <param name="userInputOrderAmount">product total amount</param>
        public static void addCustomerOrder(string userInputOrderBarCode, string userInputOrderProductDescription, string userInputOrderPrice, string userInputOrderQuantity, string userInputOrderDiscount, string userInputOrderAmount)
        {
            // need to check for duplicate lists in dictionary
            List<string> dictionaryList = new List<string> { userInputOrderProductDescription, userInputOrderPrice, userInputOrderQuantity, userInputOrderDiscount, userInputOrderAmount };
            customerTransactionDictionary.Add(userInputOrderBarCode, dictionaryList);
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
    }
}
