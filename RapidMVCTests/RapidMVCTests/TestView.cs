﻿namespace cpGames.core.RapidMVC.Tests
{
    [Context("TestContext")]
    public class TestView : View
    {
        #region Properties
        [Inject("TestName")]
        public string Name { get; set; }

        [Inject]
        public Nested1 Nested1 { get; set; }

        [Inject]
        public Nested2 Nested2 { get; set; }

        public bool PropertyUpdated { get; set; }
        #endregion

        #region Constructors
        public TestView()
        {
            PropertyUpdatedSignal.AddCommand(key =>
            {
                PropertyUpdated = true;
            });
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return Name;
        }
        #endregion
    }

    public class Nested1 { }

    public class Nested2 { }
}