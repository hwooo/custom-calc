using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace custom_calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // '=' 연산 이전까지의 연산자 버튼 클릭 횟수
        private int _opCount;

        // 총 연산자 버튼 클릭 횟수
        private int _allOpCount;

        // 모든 버튼에 대한 클릭 횟수
        private int _totalCount;

        // 이전에 입력한 값
        private int _preValue;

        // 자릿수 누적을 위한 임시 값
        private int _tempValue;

        // 이제까지 입력한 누적값
        private int _total;

        // 연산자 타입
        private char _calcType = 'c';

        // 상단에 표시될 전체 수식 문자열
        private string _equation = "";

        // 현재 연산 모드(+, -, *, /, %)가 적용된 상태인지 확인
        private bool _isCalcMode;

        // 마지막으로 지우기 연산이 수행되었는지 확인
        private bool _erase;

        // 마지막으로 '=' 연산자가 실행되었는지 확인
        private bool _isEqual;

        // 자릿수 증가를 위한 10 단위의 오프셋(ex. 835 -> 5*1 + 3*10 + 8*100)
        private const int Offset = 10;

        private Stack<char> _operators = new Stack<char>();
        private Stack<int> _operands = new Stack<int>();

        /// <summary>
        /// 연산자 함수
        /// </summary>
        /// <param name="calcType"></param>
        /// <param name="preValue"></param>
        private void Calculation(char calcType, int preValue)
        {
            switch (calcType)
            {
                case '+':
                    _total += preValue;
                    break;
                case '-':
                    _total -= preValue;
                    break;
                case '*':
                    _total *= preValue;
                    break;
                case '/':
                    _total /= preValue;
                    break;
            }
        }

        /// <summary>
        /// 숫자 0 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button0_click(object sender, RoutedEventArgs e)
        {
            _tempValue = _preValue * Offset;
            _preValue = _tempValue;

            _isCalcMode = false;
            ++_totalCount;

            if (_isEqual)
            {
                savedvalue_label.Content = _equation;
                _isEqual = false;
            }

            result_label.Content = _tempValue.ToString();
        }

        /// <summary>
        /// 숫자 1 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            _tempValue = _preValue * Offset + 1;
            _preValue = _tempValue;

            _isCalcMode = false;
            ++_totalCount;

            if (_isEqual)
            {
                savedvalue_label.Content = _equation;
                _isEqual = false;
            }

            result_label.Content = _tempValue.ToString();
        }

        /// <summary>
        /// 숫자 2 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            _tempValue = _preValue * Offset + 2;
            _preValue = _tempValue;

            _isCalcMode = false;
            ++_totalCount;

            if (_isEqual)
            {
                savedvalue_label.Content = _equation;
                _isEqual = false;
            }

            result_label.Content = _tempValue.ToString();
        }

        /// <summary>
        /// 숫자 3 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            _tempValue = _preValue * Offset + 3;
            _preValue = _tempValue;

            _isCalcMode = false;
            ++_totalCount;

            if (_isEqual)
            {
                savedvalue_label.Content = _equation;
                _isEqual = false;
            }

            result_label.Content = _tempValue.ToString();
        }

        /// <summary>
        /// 숫자 4 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            _tempValue = _preValue * Offset + 4;
            _preValue = _tempValue;

            _isCalcMode = false;
            ++_totalCount;

            if (_isEqual)
            {
                savedvalue_label.Content = _equation;
                _isEqual = false;
            }

            result_label.Content = _tempValue.ToString();
        }

        /// <summary>
        /// 숫자 5 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            _tempValue = _preValue * Offset + 5;
            _preValue = _tempValue;

            _isCalcMode = false;
            ++_totalCount;

            if (_isEqual)
            {
                savedvalue_label.Content = _equation;
                _isEqual = false;
            }

            result_label.Content = _tempValue.ToString();
        }

        /// <summary>
        /// 숫자 6 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            _tempValue = _preValue * Offset + 6;
            _preValue = _tempValue;

            _isCalcMode = false;
            ++_totalCount;

            if (_isEqual)
            {
                savedvalue_label.Content = _equation;
                _isEqual = false;
            }

            result_label.Content = _tempValue.ToString();
        }

        /// <summary>
        /// 숫자 7 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            _tempValue = _preValue * Offset + 7;
            _preValue = _tempValue;

            _isCalcMode = false;
            ++_totalCount;

            if (_isEqual)
            {
                savedvalue_label.Content = _equation;
                _isEqual = false;
            }

            result_label.Content = _tempValue.ToString();
        }

        /// <summary>
        /// 숫자 8 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            _tempValue = _preValue * Offset + 8;
            _preValue = _tempValue;

            _isCalcMode = false;
            ++_totalCount;

            if (_isEqual)
            {
                savedvalue_label.Content = _equation;
                _isEqual = false;
            }

            result_label.Content = _tempValue.ToString();
        }

        /// <summary>
        /// 숫자 9 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, RoutedEventArgs e)
        {
            _tempValue = _preValue * Offset + 9;
            _preValue = _tempValue;

            _isCalcMode = false;
            ++_totalCount;

            if (_isEqual)
            {
                savedvalue_label.Content = _equation;
                _isEqual = false;
            }

            result_label.Content = _tempValue.ToString();
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            // 총 연산자 클릭 횟수가 0 이상인데 수식 문자열이 비어 있다면 이전에 '=' 연산을 하고 초기화된 상태이므로,
            // 피연산자 없이 연산 모드를 실행할 수는 없기 때문에 함수를 종료한다.
            if (_isCalcMode || _totalCount == 0 || (_allOpCount > 0 && _equation == ""))
            {
                return;
            }

            _isCalcMode = true;

            if (_opCount == 0)
            {
                _total = _preValue;
            }
            else
            {
                // 덧셈 연산을 하기 전 기존의 연산을 완료한다.
                Calculation(_calcType, _preValue);
            }

            _calcType = '+';
            _tempValue = 0;

            ++_opCount;
            ++_allOpCount;
            ++_totalCount;

            // 이전에 지우기 연산을 했을 경우 _preValue를 연결하지 않는다.
            if (_erase)
            {
                _equation += " + ";
                _erase = false;
            }
            else
            {
                _equation += _preValue + " + ";
            }

            _preValue = 0;
            savedvalue_label.Content = _equation;

            // 연산자를 입력하면 이전까지 계산된 수식을 출력한다.
            // ex) "9 + 3"을 입력하고 "-"를 입력하면 9 + 3 = 12가 결과 창에 표시되는 것이다.
            result_label.Content = _total.ToString();
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            if (_isCalcMode || _totalCount == 0 || (_allOpCount > 0 && _equation == ""))
            {
                return;
            }

            _isCalcMode = true;

            if (_opCount == 0)
            {
                _total = _preValue;
            }
            else
            {
                Calculation(_calcType, _preValue);
            }

            _calcType = '-';
            _tempValue = 0;

            ++_opCount;
            ++_allOpCount;
            ++_totalCount;

            if (_erase)
            {
                _equation += " - ";
                _erase = false;
            }
            else
            {
                _equation += _preValue + " - ";
            }

            _preValue = 0;
            savedvalue_label.Content = _equation;
            result_label.Content = _total.ToString();
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            if (_isCalcMode || _totalCount == 0 || (_allOpCount > 0 && _equation == ""))
            {
                return;
            }

            _isCalcMode = true;

            if (_opCount == 0)
            {
                _total = _preValue;
            }
            else
            {
                Calculation(_calcType, _preValue);
            }

            _calcType = '*';
            _tempValue = 0;

            ++_opCount;
            ++_allOpCount;
            ++_totalCount;

            if (_erase)
            {
                _equation += " * ";
                _erase = false;
            }
            else
            {
                _equation += _preValue + " * ";
            }

            _preValue = 0;
            savedvalue_label.Content = _equation;
            result_label.Content = _total.ToString();
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
            if (_isCalcMode || _totalCount == 0 || (_allOpCount > 0 && _equation == ""))
            {
                return;
            }

            _isCalcMode = true;

            if (_opCount == 0)
            {
                _total = _preValue;
            }
            else
            {
                Calculation(_calcType, _preValue);
            }

            _calcType = '/';
            _tempValue = 0;

            ++_opCount;
            ++_allOpCount;
            ++_totalCount;

            if (_erase)
            {
                _equation += " / ";
                _erase = false;
            }
            else
            {
                _equation += _preValue + " / ";
            }

            _preValue = 0;
            savedvalue_label.Content = _equation;
            result_label.Content = _total.ToString();
        }

        /// <summary>
        /// C(Clear) 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonC_Click(object sender, RoutedEventArgs e)
        {
            _calcType = 'c';

            _opCount = 0;
            _allOpCount = 0;
            _totalCount = 0;
            _total = 0;
            _preValue = 0;
            _tempValue = 0;

            _erase = false;
            _isEqual = false;

            _equation = "";

            savedvalue_label.Content = "";
            result_label.Content = _total.ToString();
        }

        /// <summary>
        /// 지우기(←) 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void erase_Click(object sender, RoutedEventArgs e)
        {
            _erase = true;
            ++_totalCount;

            // 마지막으로 입력된 값을 수식에 이어붙인다.
            _equation += _preValue;

            // 마지막에 입력한 것이 연산자라면 _equation 문자열에서 끝의 4개 문자를 지운다.
            // ex) "9 + 2 * _" → (지우기 버튼 클릭) → "9 + 2"
            // 마지막에 입력한 것이 피연산자라면 끝의 1개 문자를 지우고, 현재 입력값을 0으로 바꾼다.
            // ex) "9 + 2 * 7" → (지우기 버튼 클릭) → "9 + 2 * "
            if (_isCalcMode)
            {
                _equation = _equation.Remove(_equation.Length - 4, 4);

                // 연산자를 새로 입력해야 하므로 상태 값을 false로 바꿔 둔다.
                _isCalcMode = false;

                // 연산자 이전에는 피연산자가 입력되었을 것이므로, 연산 타입을 초기화한다.
                _calcType = 'c';
            }
            else
            {
                _equation = _equation.Remove(_equation.Length - 1, 1);

                // 연산 모드를 다시 활성화한다.
                _isCalcMode = true;

                // 피연산자를 처음부터 새로 입력해야 하므로 이전 입력값을 초기화한다.
                _preValue = 0;
            }

            savedvalue_label.Content = _equation;
            result_label.Content = 0.ToString();
        }

        /// <summary>
        /// '=' 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void equal_Click(object sender, RoutedEventArgs e)
        {
            _isEqual = true;
            ++_totalCount;

            // Clear 버튼을 누른 상태라면 '=' 연산은 동작하지 않는다.
            if (_calcType == 'c')
            {
                return;
            }

            // 마지막으로 입력된 값이 있으면 수식에 이어붙인다.
            _equation += _preValue + " = ";

            // 마지막 연산을 수행한다.
            Calculation(_calcType, _preValue);

            // 연산 값들을 모두 초기화한다.
            _preValue = 0;
            _tempValue = 0;
            _calcType = 'c';
            _isCalcMode = false;
            _opCount = 0;

            savedvalue_label.Content = _equation;
            result_label.Content = _total.ToString();

            _total = 0;
            _equation = "";
        }
    }
}
