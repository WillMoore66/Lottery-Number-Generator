using System.Collections;

namespace Dubber_Code_Test
{
	public partial class Form1 : Form
	{
		List<int> allValues = new List<int>();
		int randIndex = 0;
		bool bonusBallMode = false;

		public Form1()
		{
			InitializeComponent();
			this.Text = "Lottery Number Generator";
			ResultRichText.ReadOnly = true;
			ResultRichText.SelectionAlignment = HorizontalAlignment.Center;
			//With more time it would be nice to make the range and quantity of numbers user-editable
			PopulateRandomNumList(1, 50);
		}

		void GenerateNumbersButton_Click(object sender, EventArgs e)
		{
			List<int> randomNums;

			if (bonusBallMode)
			{
				ResultRichText.SelectionBackColor = Color.FromArgb(0, 49, 105);
				ResultRichText.SelectionColor = Color.White;
				ResultRichText.AppendText("\n\n Bonus ball: ");
				ResultRichText.SelectionColor = Color.Black;

				randomNums = GenerateLotteryNumbers(1);
				GenerateNumbersButton.Visible = false;
				GenerateNumbersButton.Enabled = false;
				InstructionText.Text = "Press the reset button to restart the lottery!";
			}
			else
			{
				randomNums = GenerateLotteryNumbers(6);
				bonusBallMode = true;
				InstructionText.Text = "Press the button again to generate the bonus ball!";
			}

			randomNums.Sort();
			WriteRichText(randomNums, ResultRichText);
		}

		void ResetLotteryButton_Click(object sender, EventArgs e)
		{
			//Reset all variables and text and enables all UI elements
			bonusBallMode = false;
			ResultRichText.Text = "";
			InstructionText.Text = "Press the button below to generate numbers!";
			GenerateNumbersButton.Visible = true;
			GenerateNumbersButton.Enabled = true;
			allValues.Clear();

			//Given more time I would change this - we don't need to repopulate the list here, only reshuffle it
			PopulateRandomNumList(1, 50);
			randIndex = 0;
		}

		List<int> GenerateLotteryNumbers(int quantity)
		{
			//With more time this function could have done with some more error handling e.g. if randIndex was out of range
			if (quantity > allValues.Count)
			{
				quantity = allValues.Count;
				Console.WriteLine("Quantity was greater than the total range");
			}

			List<int> randomValues = allValues.GetRange(randIndex, quantity);
			randIndex += quantity;

			return randomValues;
		}

		void PopulateRandomNumList(int min, int max)
		{
			//This function creates a list of all the values from min to max and then shuffles it
			//and takes the first few values, which ensures there are no duplicates
			Random random = new Random();

			for (int i = min; i < max; i++)
			{
				allValues.Add(i);
			}

			//Work backwards through the list, swapping each value with a random other value
			for (int i = allValues.Count - 1; i > 0; i--)
			{
				int j = random.Next(i + 1);
				(allValues[i], allValues[j]) = (allValues[j], allValues[i]);    //Swap the values
			}
		}

		void WriteRichText(List<int> randomNums, RichTextBox richText)
		{
			//This for loop is required because we are setting multiple colors within one text box
			for (int i = 0; i < randomNums.Count; i++)
			{
				richText.SelectionBackColor = GetColorForNum(randomNums[i]);
				richText.AppendText(randomNums[i].ToString());

				if (i < randomNums.Count - 1)
				{
					richText.AppendText(", ");
				}
			}

			////Without the colored backgrounds the text display is reduced to just these 2 lines
			//string buttonTextResult = string.Join(", ", randomNums);
			//ResultRichText.Text = buttonTextResult;
		}

		Color GetColorForNum(int num)
		{
			int range = num / 10;   //Discard the ones digit as we only care about the tens

			switch (range)
			{
				case 0:
					return Color.Gray;      //1-9
				case 1:
					return Color.Blue;      //10-19
				case 2:
					return Color.Pink;      //20-29
				case 3:
					return Color.Green;     //30-39
				case 4:
					return Color.Yellow;    //40-49
				default:
					return Color.White;
			}
		}

		void InstructionText_Click(object sender, EventArgs e)
		{

		}

		void Form1_Load(object sender, EventArgs e)
		{

		}

		void ResultRichText_TextChanged(object sender, EventArgs e)
		{

		}
	}
}