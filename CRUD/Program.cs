using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD.CRUDS.Entidades;

namespace CRUD
{
	internal static class Program
	{
		static List<IBooteable> objetosBooteables = new List<IBooteable>()
		{
			new Modelo()
		};

		private static Form1 principal;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			principal = new Form1();
			objetosBooteables.Add(principal);
			objetosBooteables.ForEach(i => i.Boot());
			Application.Run(principal);
		}
	}
}
