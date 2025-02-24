const cities = [
  { "city": "Londra", "offset": 0 },
  { "city": "Chișinău", "offset": 2 },
  { "city": "București", "offset": 2 },
  { "city": "Paris", "offset": 1 },
  { "city": "Berlin", "offset": 1 },
  { "city": "Washington, D.C.", "offset": -5 },
  { "city": "Kathmandu", "offset": 5.75 },
  { "city": "Adelaide", "offset": 9.5 },
  { "city": "Beijing", "offset": 8 },
  { "city": "Moscova", "offset": 3 },
  { "city": "Tokyo", "offset": 9 },
  { "city": "New Delhi", "offset": 5.5 },
  { "city": "Ottawa", "offset": -5 },
  { "city": "Canberra", "offset": 10 },
  { "city": "Brasilia", "offset": -3 },
  { "city": "Riyadh", "offset": 3 },
  { "city": "Seoul", "offset": 9 },
  { "city": "Ankara", "offset": 3 },
  { "city": "Buenos Aires", "offset": -3 },
  { "city": "Pretoria", "offset": 2 },
  { "city": "Jakarta", "offset": 7 },
  { "city": "Mexico City", "offset": -6 },
  { "city": "Rome", "offset": 1 },
  { "city": "Madrid", "offset": 1 },
  { "city": "Bangkok", "offset": 7 },
  { "city": "Cairo", "offset": 2 },
  { "city": "Tehran", "offset": 3.5 },
  { "city": "Baghdad", "offset": 3 },
  { "city": "Nairobi", "offset": 3 },
  { "city": "Manila", "offset": 8 },
  { "city": "Hanoi", "offset": 7 }
];

document.addEventListener('DOMContentLoaded', (event) => {
  const fromCitySelect = document.getElementById("fromCity");
  const toCitySelect = document.getElementById("toCity");
  const fromCityDateTimeSelect = document.getElementById("fromCityDateTime");
  const toCityDateTimeSelect = document.getElementById("toCityDateTime");

  cities.forEach(city => {
      const optionFrom = document.createElement("option");
      optionFrom.value = city.city;
      optionFrom.textContent = city.city;
      fromCitySelect.appendChild(optionFrom);

      const optionTo = document.createElement("option");
      optionTo.value = city.city;
      optionTo.textContent = city.city;
      toCitySelect.appendChild(optionTo);

      const optionFromDateTime = document.createElement("option");
      optionFromDateTime.value = city.city;
      optionFromDateTime.textContent = city.city;
      fromCityDateTimeSelect.appendChild(optionFromDateTime);

      const optionToDateTime = document.createElement("option");
      optionToDateTime.value = city.city;
      optionToDateTime.textContent = city.city;
      toCityDateTimeSelect.appendChild(optionToDateTime);
  });

  // Setează ora locală ca valoare implicită
  const now = new Date();
  const localHours = now.getHours().toString().padStart(2, '0');
  const localMinutes = now.getMinutes().toString().padStart(2, '0');
  document.getElementById("inputTime").value = `${localHours}:${localMinutes}`;
});
