[int]$operacao = 0

while($true)
{
    Clear-Host
    Write-Host "Exercício 03" -ForegroundColor Cyan
    Write-Host ""
    Write-Host "Integrantes: Gabriella Dantas de Abreu Fandim, João Gustavo Medeiros Pontes" -ForegroundColor Magenta
    Write-Host ""
    Write-Host "[1] DATE
[2] get-process
[3] DIR
[4] get-help
[5] PWD
[6] SAIR" -ForegroundColor Yellow
    Write-Host ""

    $operacao = [int](Read-Host)

    if ($operacao -eq 1)
    {
        Get-Date
        Read-Host
    }
    else
    {
        if ($operacao -eq 2)
        {
            Get-Process
            Read-Host
        }
        else
        {
            if ($operacao -eq 3)
            {
                Get-ChildItem
                Read-Host
            }
            else
            {
                if ($operacao -eq 4)
                {
                    Get-Help
                    Read-Host
                }
                else
                {
                    if ($operacao -eq 5)
                    {
                        Get-Location
                        Read-Host
                    }
                    else
                    {
                        if ($operacao -eq 6)
                        {
                            Write-Host ""
                            Write-Host "Saindo do script ..." -ForegroundColor Red
                            Start-Sleep -Seconds 2
                            break
                        }
                    }
                }
            }
        }
    }
}