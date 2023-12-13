using SeaBattleWPF.API.Game;
using SeaBattleWPF.mvvm;
using SeaBattleWPF.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SeaBattleWPF.VM
{
    public class RegistrationVM : BaseVM
    {
        public string LoginText { get; set; }
        private PasswordBox pass;

        public CommandVM Back { get; set; }

        public CommandVM Registration { get; set; }

        public RegistrationVM()
        {
            Registration = new CommandVM(() =>
            {
                if (User.TryRegister(LoginText, pass.Password))
                {
                    MessageBox.Show("Вы зарегистрированы!");
                    Back.Execute(new ());
                }
                    
                else
                    MessageBox.Show("Вы не зарегистрированы(");

               
            });

            Back = new CommandVM(() =>
            {
                PageControl.GetInstance().CurrentPage = new LoginPage();
            });


        }

        public void RegisterPasswordBox(PasswordBox passwordBox) => pass = passwordBox;




    }
}
