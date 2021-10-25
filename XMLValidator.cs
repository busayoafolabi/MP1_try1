// MP1: XML Validator
// Implementation of the XMLValidator class.

// You should implement this class.
// You should add comments, documentation comments, and improve the documentation.

using System;
using System.Collections.Generic;
using System.Text;

namespace XMLValidator
{
    public class XMLValidator
    {
        //field(s) here

        //declare queues in here and initialize them in bottom two constructors

        //****DOUBLE CHECK
        public Queue<XMLTag> newTags = new Queue<XMLTag>();
        public Queue<XMLTag> newTags2 = new Queue<XMLTag>();


        /// <summary>
        /// initialize your validator to store an empty queue of XML tags
        /// </summary>
        public XMLValidator()
        {
            //empty queue
            Queue<XMLTag> newTags = new Queue<XMLTag>();

        }

        /// <summary>
        /// initialize your validator with an entirely separate 
        /// copy of the queue that was passed in
        /// </summary>
        /// <param name="tags"></param>
        public XMLValidator(Queue<XMLTag> tags)
        {
            //a copy of queue newTags stored in newTags2
            newTags2 = newTags;

        }

        /// <summary>
        /// add the given tag to the end of your validator's queue.
        /// If the tag passed is null, you should throw an "ArgumentException"
        /// </summary>
        /// <param name="tag"></param>
        public void AddTag(XMLTag tag)
        {
            if (tag is null)
            {
                throw new ArgumentException("The tag is null");



            }
            else
                newTags.Enqueue(tag);
        }

        /// <summary>
        /// should display a queue of all tags that were passed
        /// to the constructor (if any) in their proper order
        /// </summary>
        /// <returns> a string that contains your validator's queue of XML tags </returns>

        public string GetTags()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("front [ ");
            foreach (XMLTag x in this.newTags2)
            {
                sb.Append(x.ToString());
                sb.Append(", ");
            }

            if (this.newTags2.Count != 0)
            {
                sb.Remove(sb.Length - 2, 2);
            }

            sb.Append(" ] back");

            return sb.ToString();
        }

        /// <summary>
        /// Remove from your validator's queue any tags that match the given element
        /// </summary>
        /// <param name="element"></param>
        public void Remove(string element)
        {
            foreach (XMLTag word in newTags2)
            {
                //for each entry in queue, if <element> or ,/element> is in the queue --> queue remove

                //word.GetElement gives the tag without the brackets
                if (word.GetElement().Contains(element))
                {
                    //removing from the queue copy
                    newTags2.Dequeue();
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
            MyStack validateStack = new MyStack;
            int index = 0;

            foreach (XMLTag tag in newTags)
            {
                if (tag.GetIsOpenTag() == true && tag.IsSelfClosing() == false)
                {

                    int lengthVal = tag.ToString().Length + index;
                    Console.WriteLine(tag.ToString().PadLeft(lengthVal));

                    validateStack.Push(tag);
                    index += 3;

                }

                else if (tag.IsSelfClosing())
                {

                    int lengthVal = tag.ToString().Length + index;
                    Console.WriteLine(tag.ToString().PadLeft(lengthVal));
                    index += 3;

                }


                else
                {
                    XMLTag testTag = validateStack.Pop();

                    if (tag.Matches(testTag))
                    {

                        index -= 3;
                        int lengthVal = tag.ToString().Length + index;
                        Console.WriteLine(tag.ToString().PadLeft(lengthVal));

                    }
                    else
                    {
                        Console.WriteLine("ERROR: Tags are NOT matching.");
                        validateStack.Push(testTag);
                    }
                }
            }
        }

    }
}