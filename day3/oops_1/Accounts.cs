using System;

class Accounts
{
        #region My Variables
    int v_accNo;
    string v_accName;
    double v_accBalance;
    bool v_isAccountActive;
       public int v_intrestRate;
#endregion
 
        #region My Properties
    public int AccountNumber
    {
        get{ return v_accNo;}
        set{v_accNo  = value;}
    }

    public string AccountName
    {
        get{return v_accName;}
        set{v_accName = value;}
    }

    public double AccountBalance
    {
        get{return v_accBalance;}
        set{v_accBalance = value;}
    }

    public bool isAccountActive
    {
        get{return v_isAccountActive;}
        set{v_isAccountActive = value;}
    }
#endregion

        #region My Methods
    public double Widraw(int w_amount)
    {
        AccountBalance = AccountBalance - w_amount;
        return AccountBalance;
    }

    public double Deposit(int d_amount)
    {
        AccountBalance = AccountBalance + d_amount;
        return AccountBalance;
    }

    public double CheckBalance()
    {
        return AccountBalance;
    }
    #endregion

}
