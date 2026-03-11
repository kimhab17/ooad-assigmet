using System;
using System.Windows.Forms;

namespace saleAndBillingSystem
{
    // 2. Factory Method Pattern: Centralizes and encapsulates the creation of specific Form objects.
    // Instead of loginForm instantiating varying forms directly, it asks the Factory.
    public static class FormFactory
    {
        public static Form CreateMainForm(string role, loginForm login)
        {
            if (role.Trim().Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                return new AdminForm();
            }
            else if (role.Trim().Equals("Cashier", StringComparison.OrdinalIgnoreCase))
            {
                return new CashierForm(login);
            }
            else
            {
                throw new ArgumentException("Invalid role provided for FormFactory.");
            }
        }
    }
}
