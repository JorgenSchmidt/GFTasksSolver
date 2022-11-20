using Core.Entities;
using GFDirectTasksSolver.ViewModelService;
using System;
using System.Collections.Generic;

namespace GFDirectTasksSolver
{
    public class MainWindowViewModel : NotifyPropertyChanged
    {
        #region переменные для взаимодействия с графическими элементами приложения

        public List<Line> anomalyModelLines = new List<Line>();
        public List<Line> AnomalyModelLines
        {
            get
            {
                return anomalyModelLines;
            }
            set
            {
                anomalyModelLines = value;
                CheckChanges();
            }
        }

        public List<Line> environmentModelLines = new List<Line>();
        public List<Line> EnvironmentModelLines
        {
            get
            {
                return environmentModelLines;
            }
            set 
            { 
                environmentModelLines = value;
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
                        // Not implemented
                        throw new NotImplementedException();
                    }
                );
            }
        }

        #endregion

        #region переменные для передачи данных по аномалии между моделью и визуальным представлением приложения 

        //
        public List<AnomalyPoint> anomalyPoints;
        public List<AnomalyPoint> AnomalyPoints
        {
            get
            {
                return anomalyPoints;
            }
            set
            {
                anomalyPoints = value;
                CheckChanges();
            }
        }

        #endregion

        #region переменные для отображения в визуальном представлении численных значений делений на координатной плоскости

        public decimal dg_max;
        /// <summary>
        /// Максимальное значение по оси dg
        /// </summary>
        public decimal dg_Max
        {
            get
            {
                return dg_max;
            }
            set
            {
                dg_max = value;
                CheckChanges();
            }
        }

        public decimal dg_med;
        /// <summary>
        /// Среднее значение по оси dg
        /// </summary>
        public decimal dg_Med
        {
            get
            {
                return dg_med;
            }
            set
            {
                dg_med = value;
                CheckChanges();
            }
        }

        public decimal x_max;
        /// <summary>
        /// Максимальное значение по оси Х
        /// </summary>
        public decimal x_Max
        {
            get
            {
                return x_max;
            }
            set
            {
                x_max = value;
                CheckChanges();
            }
        }

        public decimal x_med;
        /// <summary>
        /// Среднее значение по оси Х
        /// </summary>
        public decimal x_Med
        {
            get
            {
                return x_med;
            }
            set
            {
                x_med = value;
                CheckChanges();
            }
        }

        public decimal z_max;
        /// <summary>
        /// Максимальное значение по оси Z
        /// </summary>
        public decimal z_Max
        {
            get
            {
                return z_max;
            }
            set
            {
                z_max = value;
                CheckChanges();
            }
        }

        public decimal z_med;
        /// <summary>
        /// Среднее значение по оси Z
        /// </summary>
        public decimal z_Med
        {
            get
            {
                return z_med;
            }
            set
            {
                z_med = value;
                CheckChanges();
            }
        }

        #endregion
    }
}