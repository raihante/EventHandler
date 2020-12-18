using System;
using System.Collections.Generic;
using System.Text;
using RegisterPages.Model;

namespace RegisterPages.Controller
{
    class MainWindowController
    {
        RegisterUser registerUser;
        EmailVerification emailVerification;
        WhatsappVerification whatsappVerification;
        public MainWindowController()
        {

            registerUser = new RegisterUser();
            emailVerification = new EmailVerification();
            whatsappVerification = new WhatsappVerification();
        }
        public void registeringUser(String name, String email, String phoneNumber)
        {
            registerUser.RegisterAUser();
        }
        public void SubscribeEmailVerification()
        {
            registerUser.registerUserEvent += emailVerification.OnUserRegistered;
        }
        public void UnsubscribeEmailVerification()
        {
            registerUser.registerUserEvent -= emailVerification.OnUserRegistered;
        }
        public void SubscribeWAVerification()
        {
            registerUser.registerUserEvent += whatsappVerification.OnUserRegistered;

        }
        public void UnsubscribeWAVerification()
        {
            registerUser.registerUserEvent -= whatsappVerification.OnUserRegistered;

        }

        public void SubcribeVerificationResult(Respon listener)
        {
            whatsappVerification.waVerificationEvent += listener.Jikaverifwasukses;
            emailVerification.emailVerificationEvent += listener.Jikaverifemailsukses;
        }

    }
}
