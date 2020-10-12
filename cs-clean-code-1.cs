/* Example of a badly written class 
   DiscountManager class is responsible for calculating a discount for the customer while they are buying some product in online shop.
   
   Give a discount based on what type of customer it is
   Give a loyalty discount which equals the amount of years the customer has been active, with a maximum of 5
*/

public class DiscountManager
{
  public decimal Calculate(decimal amount, int type, int years)
  {
    decimal result = 0;
    decimal disc = (years > 5) ? (decimal)5/100 : (decimal)years/100; 
    if (type == 1)
    {
      result = amount;
    }
    else if (type == 2)
    {
      result = (amount - (0.1m * amount)) - disc * (amount - (0.1m * amount));
    }
    else if (type == 3)
    {
      result = (0.7m * amount) - disc * (0.7m * amount);
    }
    else if (type == 4)
    {
      result = (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount));
    }
    return result;
  }
}
