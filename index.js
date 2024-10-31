/*
let numero = 1;
let numero2 = 1;
let num1 = numero + numero2;

function result(num1) {
  if (num1 < 10) {
    console.log("numero inalido");
  } else {
    console.log("realmente inalido");
  }
}
result(num1);

function soma(x, y) {
  const resultado = x * y;
  return resultado;
}
const resultado = soma(10, 10);
console.log(resultado);


*/
/*
const user = document.querySelector('#name').value;

const name = ['joão','pedro'];

let result = false;

function login (name){

  for(l =0, l< length.name;l++)
  {




  if(user === name[l]){
    result = true;
    break;
  }
}

  if(result){
    console.log('bem-indo')
  }

}
login(name);
  
*/
/*
const num1 = ["1", "2", "3", "4", "5"];

let verdadeiro = NaN;

const num2 = 10 + num1[4];
let contador = 0;

const myfunction = () => {
  for (let l = 0; l < num1.length; l++)
    if (num1[l] > 100) {
      contador = l;
      verdadeiro = true;
    }

  if (verdadeiro) {
    console.log(`seu numero é ${num1[contador]}`);
  } else console.log("false");
};
myfunction();

*/

const tenhoGrana = "";

if (tenhoGrana) {
  console.log("vou sair");
} else {
  console.log("não vou sair");
}

let mes = 4;

switch (mes) {
  case (mes = 0):
    console.log("domingo");
    break;
  case (mes = 1):
    console.log("segunda");
    break;
  case (mes = 2):
    console.log("terça");
    break;
  case (mes = 3):
    console.log("quarta");
    break;
  case (mes = 4):
    console.log("quinta");
    break;
}
