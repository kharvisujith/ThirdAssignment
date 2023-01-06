// See https://aka.ms/new-console-template for more information
using ThirdAssignment;


Counter inst1 = Counter.GetInstance;
Counter inst2 = Counter.GetInstance;

inst1.increment();
inst2.decrement();
/*inst1.decrement();
inst2.decrement();*/
// because of singleton class, bothe inst1 and inst2 will refer to same memory location , both inst1 and inst2 are same
int value = inst1.count;
Console.WriteLine(value);





