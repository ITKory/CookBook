using Model.Lib.DataModels;
using System.Windows;

namespace CookBook.Services.Controls
{
    public class Layer : Overlay
    {
        #region Fields

        public static readonly DependencyProperty MaxInnerWidthProperty = DependencyProperty.Register(
            nameof(MaxInnerWidth),
            typeof(double),
            typeof(Layer),
            new PropertyMetadata());

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(
            nameof(Title),
            typeof(string),
            typeof(Layer),
            new PropertyMetadata());

        public static readonly DependencyProperty RecipeProperty = DependencyProperty.Register(
            nameof(RecipeProperty),
            typeof(FullRecipeInformation),
            typeof(Layer),
            new PropertyMetadata());



        #endregion

        #region Constructors

        static Layer()
        {

            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(Layer),
                new FrameworkPropertyMetadata(typeof(Layer)));

        }

        #endregion

        #region Properties

        public double MaxInnerWidth
        {
            get => (double)this.GetValue(MaxInnerWidthProperty);
            set => this.SetValue(MaxInnerWidthProperty, value);

        }

        public string Title
        {
            get => (string)this.GetValue(TitleProperty);
            set
            {
                //Show();
                this.SetValue(TitleProperty, value);
            }
        }

        public FullRecipeInformation Recipe
        {
            get => (FullRecipeInformation)this.GetValue(RecipeProperty);
            set
            {

                this.SetValue(RecipeProperty, value);
            }
        }


        protected override FrameworkElement AnimatedElement => this;

        #endregion
    }
}
