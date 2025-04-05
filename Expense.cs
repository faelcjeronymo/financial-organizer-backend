public class Expense
{
	public int Id { get; set; }
	public string Description { get; set; }
	public decimal Value { get; set; }
	public PaymentType PaymentType { get; set; }
	public bool Payed { get; set; }
	public int ParcelNumber { get; set; }
	public string AditionalInfo { get; set; }
	public DateTime CreatedAt { get; set; }
	public DateTime DueDate { get; set; }
	public TransactionCategory TransactionCategory { get; set; }
	public bool FixedExpense { get; set; }
}