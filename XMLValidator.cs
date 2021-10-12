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

        /// <summary>
        /// initialize your validator to store an empty queue of XML tags
        /// </summary>
        public XMLValidator()
        {
             
        }

        /// <summary>
        /// initialize your validator with an entirely separate 
        /// copy of the queue that was passed in
        /// </summary>
        /// <param name="tags"></param>
        public XMLValidator(Queue<XMLTag> tags)
        {
             
        }

        /// <summary>
        /// add the given tag to the end of your validator's queue.
        /// If the tag passed is null, you should throw an "ArgumentException"
        /// </summary>
        /// <param name="tag"></param>
        public void AddTag(XMLTag tag)
        {
            
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
        /// Remove from your validator's queue any tags that don't match the given element
        /// </summary>
        /// <param name="element"></param>
        public void Remove(string element)
        {
 
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
