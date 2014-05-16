using System;
using System.Web;
using System.Web.UI;

using System.Xml;
using System.Xml.Linq;
using System.Linq;
using System.Web.UI.WebControls;

namespace LandingPage1
{
	public partial class Default : System.Web.UI.Page
	{
		public System.Web.UI.WebControls.TextBox input;
		public System.Web.UI.WebControls.Button button;

		public virtual void button1Clicked (object sender, EventArgs args)
		{
     		XDocument data = XDocument.Load("../LandingPage1/data.xml");
     
     		Random r = new Random();
     		XElement newElement = new XElement("user", new XAttribute("ID", r.Next(50000)),
     		                                   new XAttribute("mail", input.Text));
     
     		data.Descendants("users").First().Add(newElement);
			data.Save("../LandingPage1/data.xml");
		}
	}
}

