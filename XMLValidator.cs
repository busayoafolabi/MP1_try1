// MP1: XML Validator
// Implementation of the XMLValidator class.

// You should implement this class.
// You should add comments, documentation comments, and improve the documentation.

using System;
using System.Collections.Generic;
using System.Text;

namespace XMLValidatorNS
{
    public class XMLValidator
    {
        //field(s) here

        //****DOUBLE CHECK
        public Queue<XMLTag> newTags = new Queue<XMLTag>();


        /// <summary>
        /// initialize your validator to store an empty queue of XML tags
        /// </summary>
        public XMLValidator()
        {
            //***double check!!
            Queue<XMLTag> newTags = new Queue<XMLTag>();

        }

        /// <summary>
        /// initialize your validator with an entirely separate 
        /// copy of the queue that was passed in
        /// </summary>
        /// <param name="tags"></param>
        public XMLValidator(Queue<XMLTag> tags)
        {
            //***double check!
            Queue<XMLTag> newTags2 = new Queue<XMLTag>();

        }

        /// <summary>
        /// add the given tag to the end of your validator's queue.
        /// If the tag passed is null, you should throw an "ArgumentException"
        /// </summary>
        /// <param name="tag"></param>
        public void AddTag(XMLTag tag)//busayo
        {
            if (tag is null)
                throw new ArgumentException();//(Console.WriteLine("The tag is null"));

            //else
            //newTags.Add(tag); //what is the queue name?
        }

        /// <summary>
        /// should display a queue of all tags that were passed
        /// to the constructor (if any) in their proper order
        /// </summary>
        /// <returns> a string that contains your validator's queue of XML tags </returns>
        public string GetTags() 
        {
            return null; // return a dummy value for now: ToFix
        }

        /// <summary>
        /// Remove from your validator's queue any tags that match the given element
        /// </summary>
        /// <param name="element"></param>
        public void Remove(string element)//busayo
        {
            foreach (XMLTag word in newTags)
            {
                //for each entry in queue, if <element> or ,/element> is in the queue --> queue remove
                
                //word.GetElement gives the tag without the brackets
                if (word.GetElement() == element)
                {
                    //no "Remove" keyword for Queue --> need another way - pop? dequeue?
                    newTags.Dequeue();
                }

            }
        }

        /// <summary>
        /// Print on the console an indented text representation of the XML tags currently in your queue
        /// Displays each tag in its own line.
        /// Every opening tag that requires a closing tag increases the level of indentation
        /// of the following tags by three spaces until its closing tag is reached.
        /// </summary>
        public void Validate()
        {
 
        }

    }
}
