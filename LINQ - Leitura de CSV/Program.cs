using LINQ___Leitura_de_CSV.Entities;

namespace LINQ___Leitura_de_CSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Wesley\OneDrive\Área de Trabalho\sales_customers.csv";
            List<Customer> customers = new List<Customer>();
            List<String> treatedLines = new List<string>();



            try
            {

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!(sr.EndOfStream))
                    {
                        List<String> lines = sr.ReadLine().Split(",").ToList();
                        treatedLines = eliminador(lines);
                        customers.Add(new Customer
                        {
                            ID = treatedLines[0],
                            CPF = treatedLines[1],
                            First_Name = treatedLines[2],
                            Last_Name = treatedLines[3],
                            State = treatedLines[4],
                            City = treatedLines[5],
                            BirthDate = DateTime.Parse(treatedLines[6]),
                            Income = double.Parse(treatedLines[7]),
                            Professional_Status = treatedLines[8],
                            Email = treatedLines[9],
                            Phone = treatedLines[10]

                        });
                    }


                }
                Console.WriteLine("Verificar Income de usuários: ");
                int verificar = int.Parse(Console.ReadLine());
                customers.Sort((c,x)=> c.First_Name.CompareTo(x.First_Name));
                foreach (var item in customers.Where(c => c.Income >= verificar).ToList())
                {
                    Console.WriteLine("=======================");
                    Console.WriteLine(item);
                };

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static List<String> eliminador(List<String> paraEliminar)
        {
            List<String> paraRetorno = new List<string>();
            for (int i = 0; i < paraEliminar.Count; i++)
            {
                paraRetorno.Add(paraEliminar[i].Substring(1, paraEliminar[i].Length - 2));
            }
            return paraRetorno;
        }
    }
}
