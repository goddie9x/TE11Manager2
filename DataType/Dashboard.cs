namespace TE11Manager.DataType
{
    public class Dashboard
    {
#nullable enable
        #region Properties
        private int amountUser;
        private int amountConnectPerMonth;
        private int[] amountConnectAnalyticsMonthByWeek = new int[5];
        private int amountPost;
        private int amountPostPerMonth;
        private int amountSchedule;

        public int AmountUser
        {
            get
            {
                return amountUser;
            }

            set
            {
                amountUser = value;
            }
        }

        public int AmountConnectPerMonth
        {
            get
            {
                return amountConnectPerMonth;
            }

            set
            {
                amountConnectPerMonth = value;
            }
        }

        public int[] AmountConnectAnalyticsMonthByWeek
        {
            get
            {
                return amountConnectAnalyticsMonthByWeek;
            }

            set
            {
                amountConnectAnalyticsMonthByWeek = value;
            }
        }

        public int AmountPost
        {
            get
            {
                return amountPost;
            }

            set
            {
                amountPost = value;
            }
        }

        public int AmountPostPerMonth
        {
            get
            {
                return amountPostPerMonth;
            }

            set
            {
                amountPostPerMonth = value;
            }
        }

        public int AmountSchedule
        {
            get
            {
                return amountSchedule;
            }

            set
            {
                amountSchedule = value;
            }
        }
        #endregion
        #region Constructor
        public Dashboard()
        {
            AmountUser = 0;
            AmountConnectPerMonth = 0;
            AmountConnectAnalyticsMonthByWeek = new int[5];
            AmountPost = 0;
            AmountPostPerMonth = 0;
            AmountSchedule = 0;
        }
        public Dashboard(
            int amountUser,
            int amountConnectPerMonth,
            int[] amountConnectAnalyticsMonthByWeek,
            int amountPost,
            int amountPostPerMonth,
            int amountSchedule)
        {
            AmountUser = amountUser;
            AmountConnectPerMonth = amountConnectPerMonth;
            AmountConnectAnalyticsMonthByWeek = amountConnectAnalyticsMonthByWeek;
            AmountPost = amountPost;
            AmountPostPerMonth = amountPostPerMonth;
            AmountSchedule = amountSchedule;
        }
        #endregion
        #region Methods
        #endregion
    }
}
