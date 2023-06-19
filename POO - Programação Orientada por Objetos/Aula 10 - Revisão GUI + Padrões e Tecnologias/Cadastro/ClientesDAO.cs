using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace Cadastro
{
    class ClientesDAO
    {
        private String arquivo = "./clientes.xml";
        public void addCliente(Cliente cliente)
        {
            if (File.Exists(arquivo))
            {
                XDocument doc = XDocument.Load(arquivo);
                XElement root = doc.Element("Clientes");
                root.Add(new XElement("Cliente", new XElement("Nome", cliente.getNome()), new XElement("Email", cliente.getEmail())));
                doc.Save(arquivo);
            }
            else
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.IndentChars = "  ";
                using (XmlWriter writer = XmlWriter.Create(arquivo, settings))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Clientes");
                    writer.WriteStartElement("Cliente");
                    writer.WriteElementString("Nome", cliente.getNome());
                    writer.WriteElementString("Email", cliente.getEmail());
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }
            }
        }
        public void removCliente(int index)
        {
            XElement xml = XElement.Load(arquivo);
            xml.Elements("Cliente").ElementAt(index).Remove();
            xml.Save(arquivo);
        }
        public List<Cliente> listarClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();

            if (File.Exists(arquivo))
            {
                XDocument doc = XDocument.Load(arquivo);
                foreach (XElement cliente in doc.Descendants("Cliente"))
                {
                    string nome = cliente.Element("Nome").Value;
                    string email = cliente.Element("Email").Value;
                    listaClientes.Add(new Cliente(nome, email));
                }
            }

            return listaClientes;
        }
        public void excluirArquivo()
        {
            if (File.Exists(arquivo))
            {
                File.Delete(arquivo);
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.IndentChars = "  ";
                using (XmlWriter writer = XmlWriter.Create(arquivo, settings))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Clientes");
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }
            }
        }
    }
}
