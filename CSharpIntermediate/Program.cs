using Interfaces;

/*
 * Interfaces cannot be instantiated
 */
// IOperation operation = new IOperation();

Sum sum = new Sum();
sum.Calculate(20, 50);
sum.Show();

/*
 * Polymorphism
 */
IOperation operation = new Sum();
operation.Calculate(20, 50);
operation.Show();

operation = new Subtraction();
operation.Calculate(20, 50);
operation.Show();

operation = new Multiplication();
operation.Calculate(20, 50);
operation.Show();

operation = new Division();
operation.Calculate(20, 50);
operation.Show();

