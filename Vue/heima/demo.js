import thenFs from "then-fs";
/*
thenFs.readFile('./files/1.txt','utf8').then(r1 =>{ console.log(r1)},err1 =>{console.log(err1.message)})
thenFs.readFile('./files/2.txt','utf8').then(r1 =>{ console.log(r1)},err1 =>{console.log(err1.message)})
thenFs.readFile('./files/3.txt','utf8').then(r1 =>{ console.log(r1)},err1 =>{console.log(err1.message)})
*/
/*
thenFs.readFile('./files/11.txt','utf8').then(r1 =>{ 
        console.log(r1)
        return thenFs.readFile('./files/2.txt','utf8')
    },err1 =>{
        console.log(err1.message)
    }).then(r2=>{
        console.log(r2)
        return thenFs.readFile('./files/3.txt','utf8')
    },err2=>{
        console.log(err2.message)
    }).then(r3=>{
        console.log(r3)
    },err3=>{
        console.log(err3.message)
    })
*
/
/*
thenFs.readFile('./files/11.txt','utf8').then(r1 =>{ 
        console.log(r1)
        return thenFs.readFile('./files/2.txt','utf8')
    }).then(r2=>{
        console.log(r2)
        return thenFs.readFile('./files/3.txt','utf8')
    }).then(r3=>{
        console.log(r3)
    }).catch((err)=>{
        console.log(err.message)
    })
    console.log('**********************************')
*/
/*
    thenFs.readFile('./files/11.txt','utf8')
    .catch((err)=>{
        console.log(err.message)
    })
    .then(r1 =>{ 
        console.log(r1)
        return thenFs.readFile('./files/2.txt','utf8')
    }).then(r2=>{
        console.log(r2)
        return thenFs.readFile('./files/3.txt','utf8')
    }).then(r3=>{
        console.log(r3)
    })
    */
/*
    const promiseAll = [
        thenFs.readFile('./files/1.txt','utf8'),
        thenFs.readFile('./files/2.txt','utf8'),
        thenFs.readFile('./files/3.txt','utf8'),
    ]
    Promise.all(promiseAll).then(r =>{
        console.log(r);
    })
    Promise.race(promiseAll).then(r=>{
        console.log(r)
    })
*/
/*
import fs from 'fs'
function getFile(fpath){
    return new Promise(function(resolve,reject){
        
        fs.readFile(fpath,'utf8',(err,dataStr)=>{
            if(err) return reject(err)
            resolve(dataStr)
        })
    })
}

getFile('./files/1.txt').then((r1)=>{
    console.log(r1)
},(err)=>{
    console.log(err.message)
})

getFile('./files/1.txt').then((r1)=>{
    console.log(r1)
}).catch(err=>{
    console.log(err.message)
})
*/

async function getAllFile(){
    const r1 = await thenFs.readFile('./files/1.txt','utf8')
    console.log(r1)
    const r2 = await thenFs.readFile('./files/1.txt','utf8')
    console.log(r2)
    const r3 = await thenFs.readFile('./files/1.txt','utf8')
    console.log(r3)
}
getAllFile()