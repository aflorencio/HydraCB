using CircuitBreaker.Net.Exceptions;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace HydraCB.Sample
{
    class Program
    {
        public void hola()
        {
            Thread.Sleep(5000);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program hola = new Program();

            var circuitBreaker = new CircuitBreaker.Net.CircuitBreaker(
                TaskScheduler.Default,
                maxFailures: 2,
                invocationTimeout: TimeSpan.FromMilliseconds(4000),
                circuitResetTimeout: TimeSpan.FromMilliseconds(10000));

            try
            {
                // perform a potentially fragile call through the circuit breaker
                circuitBreaker.Execute(hola.hola);
                // or its async version
                // await circuitBreaker.ExecuteAsync(externalService.CallAsync);
            }
            catch (CircuitBreakerOpenException)
            {
                Console.WriteLine("Hello Open!");

            }
            catch (CircuitBreakerTimeoutException)
            {
                Console.WriteLine("Tiempo Out!");

            }
            catch (Exception)
            {
                Console.WriteLine("Hello World!");

            }

            try
            {
                // perform a potentially fragile call through the circuit breaker
                circuitBreaker.Execute(hola.hola);
                // or its async version
                // await circuitBreaker.ExecuteAsync(externalService.CallAsync);
            }
            catch (CircuitBreakerOpenException)
            {
                Console.WriteLine("Hello Open!");

            }
            catch (CircuitBreakerTimeoutException)
            {
                Console.WriteLine("Tiempo Out!");

            }
            catch (Exception)
            {
                Console.WriteLine("Hello World!");

            }
            try
            {
                // perform a potentially fragile call through the circuit breaker
                circuitBreaker.Execute(hola.hola);
                // or its async version
                // await circuitBreaker.ExecuteAsync(externalService.CallAsync);
            }
            catch (CircuitBreakerOpenException)
            {
                Console.WriteLine("Hello Open!");

            }
            catch (CircuitBreakerTimeoutException)
            {
                Console.WriteLine("Tiempo Out!");

            }
            catch (Exception)
            {
                Console.WriteLine("Hello World!");

            }
        }
    }
}
