using System;
using System.Windows.Controls;

namespace Boxing_Round_Interval_WPF_Browser_Application
{
    internal class BoxingRoundIntervalManager
    {
        private Page currentPage; 

        public BoxingRoundIntervalManager(Page currentPage)
        {
            this.currentPage = currentPage;
        }

        public void Initialize()
        {
            Console.WriteLine("BoxingRoundIntervalManager initialized.");
         
            if (currentPage is Page1 Page1)
            {
                Page1.BeginRoundCountdown();
            }
        }
    }
}