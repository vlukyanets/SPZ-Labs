using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
	public partial class MainForm : Form
	{
		private String FileName;

		private Random Rnd;

		private List<String> Data;

		public MainForm()
		{
			Rnd = new Random();
			InitializeComponent();
		}

		private void FileSelectBtn_Click(object sender, EventArgs e)
		{
			if (OpenFileDlg.InitialDirectory.Length == 0)
				OpenFileDlg.InitialDirectory = @"D:\";

			var dlgResult = OpenFileDlg.ShowDialog();
			if (dlgResult == DialogResult.OK)
			{
				FileName = OpenFileDlg.FileName;
				FileNameBox.Text = FileName;
			}
		}

		private void WriteDoublesToFile(FileStream fs, List<double> values)
		{
			var sw = new StreamWriter(fs);
			var str = new String(' ', 0);
			foreach(var value in values)
			{
				str += value;
				str += " ";
			}

			sw.Write(str);
			sw.Close();
		}

		private void ReadLinesFromFile(FileStream fs, out List<String> values)
		{
			values = new List<String>();

			var sr = new StreamReader(fs);
			string read = null;
			while ((read = sr.ReadLine()) != null)
				values.Add(read);

			sr.Close();
		}

		private List<double> ConvertLinesToDoubles(List<String> lines)
		{
			var doubles = new List<double>();

			foreach (var line in lines)
			{
				var possibleDoubles = line.Split(' ');
				foreach (var possibleDouble in possibleDoubles)
				{
					double result;
					bool converted = double.TryParse(possibleDouble, out result);
					if (converted)
						doubles.Add(result);
				}
			}

			return doubles;
		}

		private void GenerateBtn_Click(object sender, EventArgs e)
		{
			try
			{
				var fs = new FileStream(FileName, FileMode.Create, FileAccess.Write);

				int n = GenerateInt(2, 10);
				var values = new List<double>();
				for (int i = 0; i < n; ++i)
					values.Add(GenerateDouble(-100.0, 100.0));

				WriteDoublesToFile(fs, values);

				fs.Close();
			}
			catch (Exception)
			{}
		}

		private int GenerateInt(int L, int R)
		{
			return L + Rnd.Next(R - L);
		}

		private double GenerateDouble(double L, double R)
		{
			return (R - L) * Rnd.NextDouble() + L;
		}

		private void LoadBtn_Click(object sender, EventArgs e)
		{
			try
			{
				var fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
				ReadLinesFromFile(fs, out Data);
				fs.Close();

				NumberData.TextChanged -= NumberData_TextChanged;
				NumberData.ReadOnly = false;
				NumberData.ResetText();
				foreach (var value in Data)
					NumberData.AppendText(value + "\n");

				NumberData.ReadOnly = true;
				NumberData.TextChanged += NumberData_TextChanged;
			}
			catch (Exception)
			{}
		}

		private int GetIndexOfMinimal(List<double> values)
		{
			double value = values[0];
			int index = 0;

			for (int i = 1; i < values.Count; ++i)
				if (values[i] < value)
				{
					value = values[i];
					index = i;
				}

			return index;
		}

		private int GetIndexOfMaximal(List<double> values)
		{
			double value = values[0];
			int index = 0;

			for (int i = 1; i < values.Count; ++i)
				if (values[i] > value)
				{
					value = values[i];
					index = i;
				}

			return index;
		}

		private void PerformBtn_Click(object sender, EventArgs e)
		{
			var values = ConvertLinesToDoubles(Data);
			if (values.Count >= 2)
			{
				int minimalIndex = GetIndexOfMinimal(values);
				int maximalIndex = GetIndexOfMaximal(values);

				double temp = values[minimalIndex];
				values[minimalIndex] = values[maximalIndex];
				values[maximalIndex] = temp;
			}

			var fs = new FileStream(FileName, FileMode.Create, FileAccess.Write);
			WriteDoublesToFile(fs, values);
			fs.Close();
		}

		private void NumberData_TextChanged(object sender, EventArgs e)
		{
			var splittedLines = NumberData.Text.Split('\n');
			Data.Clear();
			foreach (var line in splittedLines)
				Data.Add(line);
		}
	}
}
