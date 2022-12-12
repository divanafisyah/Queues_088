using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueues
{
    class Program
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];

        public Program()
        {
            /*Initializing the value of the variables REAR and FRONT to -1 to indicate that
             * the queue is initially empty.*/
            FRONT = -1;
            REAR = -1;
        }
        public void insert(int element)
        {
            // this statement checks for the overflow condition
            if ((FRONT == 0 && REAR == max -1) || (FRONT == REAR + 1))
            {
                Console.WriteLine("\n Queue Overflow\n");
                return;
            }
            /*this following statement checks wether the queue is empty.If the queue is empty,
             * then the value of the REAR and FRONT variables is set to 0*/
            if (FRONT == -1)
            {
                FRONT = 0;
                REAR = 0;
            }
            else
            {
                /* if REAR is Attribute the last position of the array, then the value of
                 * REAR is set to 0 that corresponds to the first position of the array.*/
                if (REAR == max - 1)
                    REAR = 0;
                else
                    /* If REAR is not at the last position, then it's value is incremented by one*/
                    REAR = REAR + 1;
            }
            /* Once the position of REAR is determined, the element is added at it/s proper place.*/
            queue_array[REAR] = element;
        }
    }
}
