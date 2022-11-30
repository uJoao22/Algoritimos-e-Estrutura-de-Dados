void Selecao(int[] array, int n) {
  for (int i = 0; i < (n-1); i++) {
    int min = i;
    for (int j = (i+1); j < n; j++) {
      if(array[j] < array[min])
        min = j;
    }

    if (array[i] != array[min]) {
      int aux = array[i];
      array[i] = array[min];
      array[min] = aux;
    }
  }
}
