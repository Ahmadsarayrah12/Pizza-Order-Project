# 🍕 Pizza Ordering System

## 📌 Overview
The **Pizza Ordering System** is a Windows Forms desktop application built with C#. It provides an interactive and user-friendly interface for customers to customize their pizza orders. The application dynamically calculates the total price based on user selections and generates a detailed order summary upon completion.

---

## 🚀 Key Features

* **Dynamic Price Calculation:** The total price updates in real-time as the user selects different sizes, crust types, and toppings.
* **Order Summary Panel:** Once the order is placed, a summary receipt is displayed showing all the chosen details.
* **State Management:** Form controls (Radio Buttons and Checkboxes) are automatically disabled after clicking "Order" to prevent accidental modifications to the finalized bill.
* **Reset Functionality:** A reset button with a confirmation dialog allows users to clear the form and start a new order safely.

---

## 🛡️ Exception Handling & Input Validation

To ensure a smooth and crash-free user experience, the application includes data validation and error handling:
* **Mandatory Field Validation:** The system checks if all required fields (Size, Crust Type, and Dining Option) are selected before processing the order (`IsOrderComplete` method). 
* **Graceful Error Prompts:** If a user tries to submit an incomplete order, a warning `MessageBox` alerts them of the missing details instead of causing unexpected behavior.
* **Safe Parsing:** Price calculations rely on safely parsing control tags, ensuring that the mathematical operations do not throw unhandled formatting exceptions during runtime.

---

## 🛠️ Technologies Used
* **Language:** C#
* **Framework:** .NET / Windows Forms
* **IDE:** Visual Studio

---

## 📸 How It Works
1. **Select Size:** Choose between Small, Medium, or Large.
2. **Choose Crust:** Select Thick or Thin crust.
3. **Add Toppings:** Pick any combination of Extra Cheese, Mushrooms, Tomatoes, Onion, Olives, or Green Peppers.
4. **Where to Eat:** Choose Eat In or Take Out.
5. **Order / Reset:** Click `Order` to view your final bill, or `Reset` to clear the form.