using Assignment6_ErrorHandling.Exceptions;
using Assignment6_ErrorHandling.Models;
using Assignment6_ErrorHandling.Services;
using System.Security.Principal;

namespace Assignment6_ErrorHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new Account
            {
                CardNumber = "123456789012",
                Pin = "1234",
                Balance = 1000,
                DailyLimit = 500,
                InvalidPinAttempts = 0,
                IsBlocked = false,
                DailyWithdrawal = 0
            };

            var atmService = new ATMService(2000);
            var authService = new AuthenticationService();
            var connectionService = new ConnectionService();

            try
            {
                connectionService.ConnectServer();
                Console.WriteLine("Welcome to XYZ Bank ATM");

                int attempts = 0;
                while (attempts < 3 && !authService.AuthenticatePin(account, PromptPin()))
                {
                    Console.WriteLine("Invalid PIN.");
                    if (account.IsBlocked)
                    {
                        Console.WriteLine("Card has been blocked due to 3 invalid attempts.");
                        return;
                    }
                    attempts++;
                }

                Console.Write("Enter withdrawal amount: ");
                decimal amount = decimal.Parse(Console.ReadLine());

                atmService.Withdraw(account, amount);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine($"Transaction failed: {ex.Message}");
            }
            catch (DailyLimitExceededException ex)
            {
                Console.WriteLine($"Transaction failed: {ex.Message}");
            }
            catch (ServerConnectionException ex)
            {
                Console.WriteLine($"Server error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }

        private static string PromptPin()
        {
            Console.Write("Enter your PIN: ");
            return Console.ReadLine();
        }
    }
}