
using System.Xml.Linq;
using System.Text;

namespace Amc_BinaryReader
{
    public partial class BinaryReader : Form
    {
        public BinaryReader()
        {
            InitializeComponent();
        }

        private void BinaryReader_Load(object sender, EventArgs e)
        {

        }

        private void readFile_btn_Click(object sender, EventArgs e)
        {
            //trasformo in un array di byte il contenuro del file foo.bin
            byte[] bytes = File.ReadAllBytes(@"C:/lorenzo/TestApp1/foo.bin");
            //converto un array di byte in una stringa binaria 
            string binaryTostring = string.Join("", bytes.Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));
            // converte una stringa binaria in una stringa ASCII
            //crea una sequenza di numeri interi che rappresentano gli indici dei byte nella stringa binaria.
            byte[] asciiBytes = Enumerable.Range(0, binaryTostring.Length / 8)
                                 //converte ogni byte nella stringa binaria in un byte utilizzando il metodo
                                 //Convert.ToByte e quindi restituisce un’enumerazione di byte.
                                 .Select(i => Convert.ToByte(binaryTostring.Substring(i * 8, 8), 2))
                                 //converte l’enumerazione di byte in un array di byte.
                                 .ToArray();
            //trasforma i singoli byte in una stringa di caratteri ASCII
            string asciiString = Encoding.ASCII.GetString(asciiBytes);


            textBox1.Text = binaryTostring;
            textBox2.Text = asciiString;
            save_btn.Visible = true;
            button1.Visible = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            textBox1.ReadOnly = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {

            string filename = textBox2.Text;
            //utilizzo il Replace per eliminare i caratteri speciali che altrimenti non mi fanno salvare il file
            string clean = filename.Replace("\u0006", "").Replace("?", "").Replace("!", "").Replace("\a", "");

            //salva il file in "C:\lorenzo\repository\Amc_BinaryReader\bin\Debug\net8.0-windows\Hello.csv"

            SaveToCsv($"{clean}.csv", textBox2.Text);
            MessageBox.Show($"Messaggio correttamente salvato in\n\\lorenzo\\repository\\Amc_BinaryReader\\bin\\Debug\\net8.0-windows\\{clean}.csv");
          

        }
        //creo un metodo per salvare quanto tradotto dal file binario in CSV
        public void SaveToCsv(string filePath, string content)
        {

            File.WriteAllText(filePath, content);

        }
        public void SavetoXml(string filePath)
        {
            // Salva la stringa ASCII in un file XML
            XDocument xdoc = new XDocument(new XElement("root", filePath));
            xdoc.Save(filePath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = textBox2.Text;
            string clean = filename.Replace("\u0006", "").Replace("?", "").Replace("!", "").Replace("\a", "");
            SavetoXml($"{clean}.xml");
            MessageBox.Show($"Messaggio correttamente salvato in\n\\lorenzo\\repository\\Amc_BinaryReader\\bin\\Debug\\net8.0-windows\\{clean}.xml");

        }
    }

}
