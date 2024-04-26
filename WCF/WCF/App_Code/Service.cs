using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	Connectioncls obj = new Connectioncls();

	public int BalanceCheck(int accno)
    {
		string sel = "select Acc_Balance from Bank_Tab where Acc_No=" + accno + "";
		SqlDataReader dr = obj.Fn_Reader(sel);
		int balance=0;
		while(dr.Read())
		{
			balance = Convert.ToInt32(dr["Acc_Balance"]);
		}
		return balance;
    }
	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}
}
