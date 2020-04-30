const circle = (radius) => Math.PI*radius*radius;
const rectangle = (l,b) => l * b;
const cylinder = (radius,height) => ((2*Math.PI*radius*height) + (2*Math.PI*radius*radius));
export{circle,rectangle,cylinder};