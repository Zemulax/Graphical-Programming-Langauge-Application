namespace MyAssignment
{
    /// <summary>
    /// method class is used to implement
    /// a method fuctionality
    /// </summary>
    public class Methods
    {
        public string[] methodLines = new string[2];
        public string[] methodname;
        public Methods() { }

        /// <summary>
        /// this method gets a specific list from the commandParser
        /// processes into ways that can be used as a method
        /// </summary>
        /// <param name="collectedMethod">a collection which contains method definition elements</param>
        public void MethodsProcessor(List<string> collectedMethod)
        {
            methodname = collectedMethod[0].Split(' ');
            methodLines[0] = collectedMethod[1];
        }
    }
}
