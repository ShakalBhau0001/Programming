let n=5
for(let i=1;i<=n;i++)
{
    let str=" ".repeat(n-i)
    console.log(str+"*".repeat(i))
}

/*
Same Output
let n=5
for(let i=1;i<=n;i++)
{
    let str=" ".repeat(n-i)+"*".repeat(i)
    console.log(str)
}
*/
