using GFDirectTasksSolver.ViewModelService;
using System.Windows.Controls;

namespace GFDirectTasksSolver
{
    public class MainWindowViewModel : NotifyPropertyChanged
    {
        #region переменные для взаимодействия с графическими элементами приложения
        
        // Переменная с информацией для отрисовки аномалии над уступом  
        public Canvas anomalyModel;
        public Canvas AnomalyModel
        {
            get
            {
                return anomalyModel;
            }
            set
            {
                anomalyModel = value;
                CheckChanges();
            }
        }

        // Переменная с информацией для отрисовки среды, содержащей моделируемый уступ
        public Canvas environmentModel;
        public Canvas EnvironmentModel
        {
            get
            {
                return environmentModel;
            }
            set
            {
                environmentModel = value;
                CheckChanges();
            }
        }
        #endregion

        #region переменные для взаимодействия с основным интерфейсом приложения

        // Переменная для отображения пользователю сообщений об ошибках / успешно завершённых операциях
        public string infoPanel;
        public string InfoPanel
        {
            get
            {
                return infoPanel;
            }
            set
            {
                infoPanel = value;
                CheckChanges();
            }
        }

        // Для ввода информации о глубине залегания нижней кромки
        public decimal depthLowerEdge;
        public decimal DepthLowerEdge
        {
            get
            {
                return depthLowerEdge;
            }
            set
            {
                depthLowerEdge = value;
                CheckChanges();
            }
        }

        // Для ввода информации о глубине залегания верхней кромки
        public decimal depthHigherEdge;
        public decimal DepthHigherEdge
        {
            get
            {
                return depthHigherEdge;
            }
            set
            {
                depthHigherEdge = value;
                CheckChanges();
            }
        }

        // Для ввода информации о плотности вмещающих пород
        public decimal hostRocksDensity;
        public decimal HostRocksDensity
        {
            get
            {
                return hostRocksDensity;
            }
            set
            {
                hostRocksDensity = value;
                CheckChanges();
            }
        }

        // Для ввода информации о плотности пород, слагающих уступ
        public decimal ledgeRocksDensity;
        public decimal LedgeRocksDensity
        {
            get
            {
                return ledgeRocksDensity;
            }
            set
            {
                ledgeRocksDensity = value;
                CheckChanges();
            }
        }

        // Для ввода информации о расположении выступа относительно нулевой оси измерения
        public decimal overhangLocation;
        public decimal OverhangLocation
        {
            get
            {
                return overhangLocation;
            }
            set
            {
                overhangLocation = value;
                CheckChanges();
            }
        }

        // Для начала расчёта аномалии силы тяжести по клику на элемент типа "Button"
        public Command CalculateAnomaly
        {
            get
            {
                return new Command(
                    (obj) =>
                    {

                    }
                );
            }
        }

        #endregion

        #region переменные для передачи данных между моделью и визуальным представлением приложения 


        #endregion
    }
}