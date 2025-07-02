use std::io; 
use rand::Rng; // Importing the Rng trait for random number generation
use colored::*; // Importing the colored crate for colored output
use std::cmp::Ordering; 

fn main(){
    println!("Guess The Number!"); 
    let secret_number = rand::rng().gen_range(1..=100); 
    loop{
        println!("Please Enter Your Guess->");
        let mut guess = String::new();
        io::stdin().read_line(&mut guess).expect("Failed to Read Line");
        let guess : u32 = match guess.trim().parse(){
            Ok(num) => num,
            Err(_) => {
                println!("⚠️  Please enter a valid number.");
                continue;
            }
        };
        println!("You guessed: {}" ,guess);
        match guess.cmp(&secret_number) {
            Ordering::Less => println!("{}📉", " ⚠️  Your guess is too low! ".cyan()),
            Ordering::Greater => println!("{}📈", " ⚠️  Your guess is too high! ".red()),
            Ordering::Equal => {
                println!("{}{}", "🎉 Congratulations! You guessed the correct number: ".green(), secret_number);
                break;
            },
        }
    }
}
