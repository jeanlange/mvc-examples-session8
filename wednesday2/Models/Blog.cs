using System;
namespace wednesday2.Models
{
    public class Blog
    {
        public int Id { get; set; }
        // we don't actually want to be able to set it - only get it.
        public int WordCount {
            // we can define how get works
            get {
                // return number of words based on text
                return Text.Split(" ").Length;
            }
        }
        private string text;
        public string Text {
            get
            {
                return this.text;
            }
            set {
                this.text = value.ToLower();
            }
        }
        public DateTime PostedOn { get; set; }
    }
}
