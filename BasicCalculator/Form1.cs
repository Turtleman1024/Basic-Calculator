using System;
using System.Linq;
using System.Windows.Forms;

namespace BasicCalculator
{       
        /// <summary>
        /// A basic calculator
        /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Clearing Methods
        /// <summary>
        /// Clears the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            //Clears the text from input text box
            UserInputText.Text = string.Empty;

            //Focus to the user input text
            FocusInputText();
        }

        /// <summary>
        /// Clears the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Clears the text from input text box
            UserInputText.Text = string.Empty;

            //Focus to the user input text
            FocusInputText();
        }

        /// <summary>
        /// Delete the char infront of the cursor
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Delete the value after the slection position
            DeleteTextValue();

            //Focus the user input text
            FocusInputText();

        }
        #endregion

        #region BinOp Methods
        /// <summary>
        /// Add the Divide character to the text at the current selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void DivideButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the current selected position
            InsertTextValue("/");

            //Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Add the Multiple character to the text at the current selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void MultipleButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the current selected position
            InsertTextValue("*");

            //Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Add the Addition character to the text at the current selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the current selected position
            InsertTextValue("+");

            //Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Add the Subtraction character to the text at the current selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void SubtractButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the current selected position
            InsertTextValue("-");

            //Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Calculates the given equation in the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void EqualButton_Click(object sender, EventArgs e)
        {
            //Calculate the equation
            CalculateEquation();

            //Focus the user input text
            FocusInputText();
        }
        #endregion

        #region Numbers Methods
        /// <summary>
        /// Insert decimal at the position of the courser in the user input text box
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void DecimalButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the current selected position
            InsertTextValue(".");

            //Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Insert zero at the position of the courser in the user input text box
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the current selected position
            InsertTextValue("0");

            //Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Insert one at the position of the courser in the user input text box
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void OneButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the current selected position
            InsertTextValue("1");

            //Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Insert two at the position of the courser in the user input text box
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void TwoButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the current selected position
            InsertTextValue("2");

            //Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Insert three at the position of the courser in the user input text box
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void ThreeButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the current selected position
            InsertTextValue("3");

            //Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Insert four at the position of the courser in the user input text box
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void FourButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the current selected position
            InsertTextValue("4");

            //Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Insert five at the position of the courser in the user input text box
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void FiveButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the current selected position
            InsertTextValue("5");

            //Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Insert siz at the position of the courser in the user input text box
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void SixButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the current selected position
            InsertTextValue("6");

            //Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Insert seven at the position of the courser in the user input text box
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void SevenButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the current selected position
            InsertTextValue("7");

            //Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Insert eight at the position of the courser in the user input text box
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void EightButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the current selected position
            InsertTextValue("8");

            //Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Insert nine at the position of the courser in the user input text box
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void NineButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the current selected position
            InsertTextValue("9");

            //Focus the user input text
            FocusInputText();
        }

        #endregion

        /// <summary>
        /// Calculates the given equation and outputs the answer to the user label
        /// </summary>
        private void CalculateEquation()
        {
            //TODO: Finish

            calculation_result_text.Text = ParseOperation();

            //Focus the user input text
            FocusInputText();
        }

        #region Parse Operation
        /// <summary>
        /// Parse the users equation and calculates the result
        /// </summary>
        /// <returns></returns>
        private string ParseOperation()
        {
            try
            {
                //Get the users equation input
                var input = UserInputText.Text;

                //Remove all spaces in the user equation
                input = input.Replace(" ", "");

                //Create a new top-level operation
                var operation = new Operation();
                var leftSide = true;

                //Loop through each character of the input
                //Starting from the left working to the right
                for(int index = 0; index < input.Length; index++)
                {
                    //TODO: Handle order priority
                    //      4 + 5 * 3
                    //      It should 5 * 3 then 4 + the result (so 4 + 3)
                    
                    //Check if the current character is a number
                    if("0123456789.".Any(element => input[index] == element))
                    {
                        if(leftSide)
                        {
                            operation.LeftSide = AddNumberPart(operation.LeftSide, input[index]);
                        }
                        else
                        {
                            operation.RightSide = AddNumberPart(operation.RightSide, input[index]);
                        }
                        
                    }
                    //If it is an operator ( + - * / ) set the operator type
                    else if("+-*/.".Any(element => input[index] == element))
                    {
                        //If we are on the right side already, we now need to calculate our current operation
                        // and set the result to the left side of the next operation
                        if(!leftSide)
                        {
                            //Get the operator type
                            var operatorType = GetOperationType(input[index]);

                            //Check if we actually have a right side number 
                            if (operation.RightSide.Length == 0)
                            {
                                //Check the operation is not a minus (as they could be creating a negative number)
                                if (operatorType != OperationType.Minus)
                                {
                                    throw new InvalidOperationException($"Operator(+*/ or more than one -) specified without an right side number");
                                }

                                //If we got here, the operator type is a minus, and there is no right number currently, so add the minus to the number
                                operation.RightSide += input[index];
                            }
                            else
                            {
                                //Calculate previous equation and set the left side
                                operation.LeftSide = CalculateOperation(operation);

                                //Set new operator
                                operation.OperationType = operatorType;

                                //Clear the previous right number
                                operation.RightSide = string.Empty;
                            }
                        }
                        else
                        {
                            //Get the operator type
                            var operatorType = GetOperationType(input[index]);

                            //Check if we actually have a left side number 
                            if(operation.LeftSide.Length == 0)
                            {
                                //Check the operation is not a minus (as they could be creating a negative number)
                                if(operatorType != OperationType.Minus)
                                {
                                    throw new InvalidOperationException($"Operator(+*/ or more than one -) specified without an left side number");
                                }

                                //If we got here, the operator type is a minus, and there is no left number currently, so add the minus to the number
                                operation.LeftSide += input[index];
                            }
                            else
                            {
                                //If we get here, we have a left number and now an operator, so we want to move to the right side

                                //Set the operation type
                                operation.OperationType = operatorType;

                                //Move to the right side
                                leftSide = false;
                            }
                        }
                    }
                }

                //If we are done parsing, and there were no excpetions
                //calculate the current operation
                return CalculateOperation(operation);
                
            }
            catch (Exception exception)
            {
                return $"Invalid equation. {exception.Message}";
            }
        }

        /// <summary>
        /// Calculate a <see cref="Operation"/> and returns the result
        /// </summary>
        /// <param name="operation">The operation to calculate</param>
        private string CalculateOperation(Operation operation)
        {
            //Store the number values of the string representations
            decimal left = 0;
            decimal right = 0;

            //Check if we have a valid left side number
            if(string.IsNullOrEmpty(operation.LeftSide) || !decimal.TryParse(operation.LeftSide, out left))
            {
                throw new InvalidOperationException($"Left side of the operation was not a number. {operation.LeftSide}");
            }

            //Check if we have a valid right side number
            if (string.IsNullOrEmpty(operation.RightSide) || !decimal.TryParse(operation.RightSide, out right))
            {
                throw new InvalidOperationException($"Right side of the operation was not a number. {operation.RightSide}");
            }

            try
            {
                switch (operation.OperationType)
                {
                    case OperationType.Add:
                        return (left + right).ToString();
                    case OperationType.Minus:
                        return (left - right).ToString();
                    case OperationType.Multiply:
                        return (left * right).ToString();
                    case OperationType.Divide:
                        return (left / right).ToString();
                    default:
                        throw new InvalidOperationException($"Unknow operator type when calculating operation. {operation.OperationType}");

                }
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException($"Failed to calculate operation {operation.LeftSide} {operation.OperationType} {operation.RightSide}. {exception.Message}");
            }
        }

        /// <summary>
        /// Accepts a character and returns the known <see cref="OperationType"/>
        /// </summary>
        /// <param name="character"> The character to parse </param>
        /// <returns></returns>
        private OperationType GetOperationType(char character)
        {
            switch(character)
            {
                case '+' :
                    return OperationType.Add;
                    break;
                case '-' :
                    return OperationType.Minus;
                    break;
                case '*' :
                    return OperationType.Multiply;
                    break;
                case '/' :
                    return OperationType.Divide;
                default :
                    throw new InvalidOperationException($"Unknown operator type {character}");
            }
        }

        /// <summary>
        /// Attempts to add a new character to the current number, checking for valid characters as it goes 
        /// </summary>
        /// <param name="currentNumber">The current number string</param>
        /// <param name="newCharacter">The new character to append to the string</param>
        /// <returns></returns>
        private string AddNumberPart(string currentNumber, char newCharacter)
        {
            //Check if there is already a . in t he number
            if(newCharacter == '.' && currentNumber.Contains('.'))
            {
                throw new InvalidOperationException($"Number {currentNumber} already contains a . and another cannot be added");
            }

            return currentNumber + newCharacter;
        }
        #endregion

        #region Private Helpers
        /// <summary>
        /// Focuses the user input text.
        /// Basically makes it so anytime a button is clicked
        /// the cursor stays in the user input textbox.
        /// </summary>       
        private void FocusInputText()
        {
            //Focusing the cursor on the user input text box
            UserInputText.Focus();
        }

        /// <summary>
        /// Inserts the given text into the user input text box
        /// </summary>
        /// <param name="value">The value to insert</param>
        private void InsertTextValue(string value)
        {
            //Remeber slection start
            var selectionStart = UserInputText.SelectionStart;

            //Set new text
            UserInputText.Text = UserInputText.Text.Insert(UserInputText.SelectionStart, value);

            //Restore the selection start
            UserInputText.SelectionStart = selectionStart + value.Length;

            //Set selection length to zero
            UserInputText.SelectionLength = 0;
        }

        /// <summary>
        /// Delete the char to the right of the slection start of the user input text box
        /// </summary>
        private void DeleteTextValue()
        {
            //If we do not have value to delete, return.
            if (UserInputText.Text.Length < UserInputText.SelectionStart + 1)
                return;

            //Remember selection start
            int selectionStart = UserInputText.SelectionStart;

            //Delete the char to the right of the selection 
            UserInputText.Text = UserInputText.Text.Remove((UserInputText.SelectionStart), 1);

            //Restore the selection start
            UserInputText.SelectionStart = selectionStart;

            //Set selection length to zero
            UserInputText.SelectionLength = 0;

        }

        #endregion

    }
}
