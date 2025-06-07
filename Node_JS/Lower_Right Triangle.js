let n=5
for(let i=n;i>=1;i--)
{
    let str=" ".repeat(n-i)
    console.log(str+"*".repeat(i))
}

/*
Same Output
let n=5
for(let i=n;i>=1;i--)
{
    let str=" ".repeat(n-i)+"*".repeat(i)
    console.log(str)
}
*/
