using System.Text.Json;
using WorkerOrderManagement.Domain.Entities;
using WorkerOrderManagement.Domain.Enums;

namespace WorkerOrderManagement;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            if (_logger.IsEnabled(LogLevel.Information))
            {
                Order orderProcesses = new Order();
                orderProcesses.EntityType = EntityType.CANDIDATE;
                orderProcesses.OperationType = OperationType.CREATE;
                orderProcesses.Status = OrderStatus.PENDING;

                orderProcesses.Aspirante = new Aspirante();
                orderProcesses.Aspirante.Apellido = "Robles";
                orderProcesses.Aspirante.Nombres = "Sergio Alexander";
                orderProcesses.Aspirante.Direccion= "Ciudad";
                orderProcesses.Aspirante.Telefono = "12345678";

                
                //Se necesita realizar un logger para cada instancia que se realice.

                _logger.LogInformation("Worker running object one: {0}", JsonSerializer.Serialize(orderProcesses));
                
            }
            }
            await Task.Delay(1000, stoppingToken);
        }
    }

