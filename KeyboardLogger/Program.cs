using System.Collections.Generic;
using System.Windows.Forms;
using Keystroke.API;

namespace KeyboardLogger
{
    class Program
    {
        private static List<string> keys = new List<string>();

        static void Main(string[] args)
        {
            using (var api = new KeystrokeAPI())
            {
                api.CreateKeyboardHook((character) =>
                {
                    if (character.KeyCode == KeyCode.Escape)
                    {
                        Application.Exit();
                    }
                    else if (character.KeyCode == KeyCode.Tab)
                    {
                        var total = string.Empty;

                        foreach (var key in keys)
                        {
                            total += key;
                        }
                        
                        MessageBox.Show(total, "Keys Pressed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        keys.Clear();
                    }
                    else
                    {
                        keys.Add(character.KeyCode.ToString());
                    }
                });

                Application.Run();
            }
        }
    }
}
