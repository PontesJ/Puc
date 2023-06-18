function Adicao()
{
    while($true)
    {
        try
        {
            Write-Host "Digite um número inteiro: " -ForegroundColor Cyan -NoNewline
            $entrada = Read-Host
            if([string]::IsNullOrEmpty($entrada))
            {
                throw "Nenhum valor foi digitado."
            }
            if($entrada -match "[,.]")
            {
                throw "A entrada deve conter apenas dígitos."
            }
            $n1 = [int]$entrada
            return $n1
        }
        catch
        {
            Write-Host "$_" -ForegroundColor Red
        }
    }
}


[float]$media = 0
[int]$soma = 0
[int]$tamanho = 0
[int]$numero

Clear-Host

Write-Host "Exercício 01" -ForegroundColor Cyan
Write-Host ""
Write-Host "Enunciado: Leia pelo teclado uma sequência de números inteiros positivos de tamanho indeterminado (fornecidos pelo usuário via teclado) e imprima a soma destes números (SOMA), a média (MEDIA) e o tamanho da sequência (N) . Para indicar o fim da sequência use como 'FLAG' (terminador) um número negativo (p. ex. -1)." -ForegroundColor Yellow
Write-Host ""
Write-Host "Integrantes: Gabriella Dantas de Abreu Fandim, João Gustavo Medeiros Pontes" -ForegroundColor Magenta
Write-Host ""

$numero = Adicao

while($numero -ge 0)
{
    $soma += $numero
    $tamanho++
    $numero = Adicao
}
Write-Host ""
if($tamanho -gt 0)
{
    $media = $soma/$tamanho
    Write-Host "A soma desses números é: $soma" -ForegroundColor Green
    Write-Host "A média desses números é: $media" -ForegroundColor Green
    Write-Host "Foram lidos: $tamanho números" -ForegroundColor Green
}
else
{
    Write-Host "Nenhum número foi lido." -ForegroundColor Red
}
Write-Host ""