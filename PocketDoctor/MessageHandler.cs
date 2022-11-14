using System.Windows.Forms;

namespace PocketDoctor
{
    static class MessageHandler
    {
        public static void ShowMessage(string msgText)
        {
            MessageBox.Show(msgText);
        }

        public static void ShowMessage(string msgText, string caption, MessageBoxButtons msgbtn, MessageBoxIcon msgIcon)
        {
            MessageBox.Show(msgText, caption, msgbtn, msgIcon);
        }
    }
}
