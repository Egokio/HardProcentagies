# Compound Interest Calculator

A simple desktop application interface designed to calculate the growth of an investment over time using the power of compound interest. 

## Features

### Input Fields
* **Principal Amount:** "How much money will you add to account" (Initial deposit).
* **Period:** The duration of the deposit (typically measured in years).
* **Deposit Rate:** The annual interest rate percentage (e.g., 5 for 5%).

### Actions
* **Calculate Button:** Processes the inputs to generate the financial breakdown.

### Output Fields
* **Total Amount:** The final balance including the principal and accumulated interest.
* **Percent Income:** The total percentage growth of the initial investment.
* **Money Income:** The absolute net profit earned purely from interest.

---

## Mathematical Logic

The application calculates the outputs using the standard annual compound interest formula:

$$A = P \left(1 + \frac{r}{100}\right)^t$$

Where:
* **A** = Total amount
* **P** = Principal amount (Money added to account)
* **r** = Deposit rate (Annual interest rate)
* **t** = Period (Time in years)

### Derived Metrics
* **Money Income** = $A - P$
* **Percent Income** = $\left(\frac{A - P}{P}\right) \times 100$

---

## Suggested Code Structure (Event Handler)

When the user clicks the **Button**, the following logical flow should execute:

1. **Validate inputs:** Ensure all three textboxes contain valid positive numbers.
2. **Perform calculation:** Apply the formulas listed above.
3. **Format outputs:** Display the results in the respective labels, rounding financial values to two decimal places (e.g., `$1,234.56`).
erest.