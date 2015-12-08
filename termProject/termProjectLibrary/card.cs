using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Utilities;

namespace termProjectLibrary
{
    public class card
    {
        private string FName;
        private string LName;
        private string ccType;
        private long ccNum;
        private string expDate;
        private int cvv;
        
        private int loginID;
        DBConnect objDB = new DBConnect();
        SqlCommand command = new SqlCommand();

        

        public card()
        {
            FName = "";
            LName = "";
            ccType = "";
            ccNum = 0;
            expDate = "";
            cvv = 0;
            loginID = 0;
        }

        public card(string cardNum)
        {
            this.NUMBER =Convert.ToInt32(cardNum);
            string queryGetData = "select cardFName,cardLName,cardExpiration,cardVerification from tp_card where cardNum='" + this.NUMBER + "'";
            DataSet dsGetData = objDB.GetDataSet(queryGetData);
            DataTable dtGetData = dsGetData.Tables[0];
            foreach (DataRow dr in dtGetData.Rows)
            {
                this.FNAME = dr["cardFName"].ToString();
                this.LNAME = dr["cardLName"].ToString();
                this.EXPDATE =dr["cardExpiration"].ToString();
                this.CVV = Convert.ToInt32(dr["cardVerification"].ToString());
            }
        }
        public card(int loginID, long cardNumber, string firstName, string lastName, string exp, int verif, string type)
        {
            this.FName = firstName;
            this.LName = lastName;
            this.ccType = type;
            this.ccNum = cardNumber;
            this.expDate = exp;
            this.cvv = verif;
            this.loginID = loginID;
        }
        public string FNAME
        {
            get { return FName; }
            set { FName = value; }
        }
        public string LNAME
        {
            get { return LName; }
            set { LName = value; }
        }
        public string CCTYPE
        {
            get { return ccType; }
            set { ccType = value; }
        }
        public string EXPDATE
        {
            get { return expDate; }
            set { expDate = value; }
        }
        public int CVV
        {
            get { return cvv; }
            set { cvv = value; }
        }
        public long NUMBER
        {
            get { return ccNum; }
            set { ccNum = value; }
        }
        public int LOGIN
        {
            get { return loginID; }
            set { loginID = value; }
        }

        public object[] addCard(card c)
        {
            object[] theCard = new object[7];

            theCard[0]= c.ccNum;
            theCard[1]= c.FName;
            theCard[2]= c.LName;
            theCard[3]= c.expDate;
            theCard[4]= c.cvv;
            theCard[5]= c.ccType;
            theCard[6]= c.loginID;

            return theCard;
        }
        public string generateCardNum()
        {
            string cardNum = "";
            char[] key = "0123456789".ToCharArray();
            Random r = new Random();
            for (int i = 0; i < 16; i++)
            {
                cardNum += key[r.Next(0, 10)].ToString();
            }
            return cardNum;
        }
        public string cardExpiration()
        {
            string month;
            string year;
            DateTime date = DateTime.Now;
            DateTime future = date.AddYears(4);
            string expDate = future.ToString();
            expDate = expDate.Substring(0, 10);
            month = expDate.Substring(0, 2);
            year = expDate.Substring(6, 4);
            expDate = month + "/" + year;
            return expDate;
        }
        public string generateCVV()
        {
            string cardCVV = "";
            char[] cvv = "0123456789".ToCharArray();
            Random r = new Random();
            for (int i = 0; i < 3; i++)
            {
                cardCVV += cvv[r.Next(0, 10)].ToString();
            }
            return cardCVV;
        }
        public Boolean cardExists(long cardNum)
        {
            DataSet foundCard = new DataSet();
            

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "dbo.TP_checkCardExists";

            SqlParameter findCard = new SqlParameter("@cardNum", cardNum);
            findCard.Direction = ParameterDirection.Input;
            findCard.SqlDbType = SqlDbType.NVarChar;
            findCard.Size = 50;
            command.Parameters.Add(findCard);
            foundCard = objDB.GetDataSetUsingCmdObj(command);

            int size = Convert.ToInt32(foundCard.Tables[0].Rows[0][0].ToString());
            if (size > 0)
            {
                return true;
            }
            else
                return false;

        }
        public Boolean cardExists(int loginID)
        {
            DataSet foundAmazonCard = new DataSet();
            SqlCommand cardByID = new SqlCommand();

            cardByID.CommandType = CommandType.StoredProcedure;
            cardByID.CommandText = "dbo.TP_checkAmazonCardExist";

            SqlParameter findAmazonCard = new SqlParameter("@loginID", loginID);
            findAmazonCard.Direction = ParameterDirection.Input;
            findAmazonCard.SqlDbType = SqlDbType.Int;
            findAmazonCard.Size = 4;
            cardByID.Parameters.Add(findAmazonCard);
            foundAmazonCard = objDB.GetDataSetUsingCmdObj(cardByID);

            int size = Convert.ToInt32(foundAmazonCard.Tables[0].Rows[0][0].ToString());
            if (size > 0)
            {
                return false;
            }
            else
                return true;

        }
    }
}
