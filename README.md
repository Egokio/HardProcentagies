# Compound Interest Calculator

A simple desktop application for calculating the growth of an investment using compound interest.

## Features

The application allows the user to enter the initial amount, investment period and annual interest rate, then calculates the final amount and income.

### Input Fields

* **Principal Amount** — the initial amount of money deposited into the account.

  * Unit: currency / money amount
  * Must be greater than 0.

* **Period** — the investment duration.

  * Unit: months
  * Must be greater than 0.

* **Deposit Rate** — the annual interest rate.

  * Unit: percentage (%)
  * Example: `5` means 5% per year.
  * Must be greater than 0.

## Calculation

The application uses monthly compound interest based on an annual interest rate.

The formula is:

```text
A = P × (1 + r / 1200)^m
```

Where:

* `A` — Total Amount
* `P` — Principal Amount
* `r` — annual interest rate in percent
* `m` — investment period in months

The income is calculated as:

```text
Money Income = A - P
```

The percentage income is calculated as:

```text
Percent Income = ((A - P) / P) × 100
```

The financial results are rounded to two decimal places.

## Outputs

After a successful calculation, the application displays:

* **Total Amount** — the final amount including the initial investment and interest.

  * Unit: currency / money amount

* **Percent Income** — the percentage growth compared with the initial amount.

  * Unit: percentage (%)

* **Money Income** — the amount earned from interest.

  * Unit: currency / money amount

## Input Validation

The application checks that:

1. The Principal Amount is a valid number.
2. The Period is a valid whole number of months.
3. The Deposit Rate is a valid number.
4. All entered values are greater than zero.

If an input is invalid, an error message is displayed and the calculation is not performed.

Previous calculation results are cleared when a new calculation is started, so an old result is not displayed when an error occurs.

## Project Structure

The solution consists of separate projects:

* **HardProcentagies** — the desktop application and user interface.
* **Calculaator** — the Class Library containing the calculation logic and value validation.

The calculation and validation logic is kept separately from the user interface.

The `Calculator` class provides static methods for:

* validating input values;
* calculating the total amount;
* calculating percentage income;
* calculating money income.


## How to Run

1. Open the solution in Visual Studio.
2. Set **HardProcentagies** as the Startup Project.
3. Build the solution.
4. Run the application.
5. Enter the Principal Amount, Period in months and annual Deposit Rate.
6. Press the **Calculate** button.

## Example

For example, if:

```text
Principal Amount = 1000
Period = 12 months
Deposit Rate = 5%
```

the application calculates the final amount using monthly compound interest and displays the total amount and income.

## Error Handling

If the user enters invalid data, the application displays an error message instead of performing the calculation.

The previous result is also cleared to prevent outdated calculation results from remaining visible.

## Purpose

The purpose of this project is to demonstrate a simple compound interest calculator while keeping the user interface separate from the calculation and validation logic.
